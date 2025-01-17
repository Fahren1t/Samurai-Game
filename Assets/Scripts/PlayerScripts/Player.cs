using System.Collections;
using UnityEngine;
using Game.EnemyScripts;

namespace Game.PlayerScripts
{
    public class Player : MonoBehaviour
        
    {

        public Animator animator; //animator for playing animations

        public float attackRate = 3f; // how many times can attack in a second
        public float defenseRate = 3f;// how many times can defend in a second

        private float nextAttackTime = 0f; //required for attack time
        private float nextDefenseTime = 0f; //required for defense time

        private bool attacking = false; //set to true while attacking
        private bool defensing = false; //set to true while defensing

        private GameObject attackArea = default; //attack area
        private GameObject defenseArea = default; //defense area

        private AttackArea attackAreaScript; //script for subscribing an event
    
        private const float attackStartDelay = 0.12f; //after how many seconds attack starts
        private const float defenseStartDelay = 0f; //after how many seconds defense starts

        private const float attackScope = 0.08f; //how long attack area stays open
        private const float defenseScope = 0.33f; //how long defense area stays open


        
        // Start is called before the first frame update
        void Start()
        {
            //makes the first object under the player is attack area
            attackArea = transform.GetChild(0).gameObject;
            //makes the second object under the player is defense area
            defenseArea = transform.GetChild(1).gameObject;

            //required for event subscription
            attackAreaScript = attackArea.GetComponent<AttackArea>();
            attackAreaScript.OnDeflectableEntered += HandleDeflectable; // Subscribe to the event

        }
        void Update()
        {
            if (!IsAnActionGoingOn())
                return;

            HandleAttackInput(); //run the attack input

            HandleDefenseInput(); //run the defense input
            HandleDeflection(); //run the deflection input
        }

        //ATTACK~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private void HandleAttackInput()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Attack();
                SetTheTimer(ref nextAttackTime, attackRate);
            }
        }

         //if V is pressed, defence
         //DEFENSE~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private void HandleDefenseInput()
        {
            if (Input.GetKeyDown(KeyCode.V))
            {
                Defense();
                SetTheTimer(ref nextDefenseTime, defenseRate);
            }
        }
        //DEFLECT~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private void HandleDeflection()
        {
            if (attackAreaScript.CanDeflect())
            {
                IDeflectable deflectable = attackAreaScript.GetDeflectableObject();
                if (deflectable != null)
                {
                    deflectable.Deflect(transform.right);
                }
            }
        }

        // Update is called once per frame
        //void Update()
        //{




        //    if (IsAnActionGoingOn())
        //    {
        //        //ATTACK~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        //        if (Input.GetKeyDown(KeyCode.Space))
        //        {

        //            Attack();
        //            //we set the next attack time = (current time) + (whatever the attack time is according to attack rate is)
        //            //(ex. if attack rate is 3 than attack time is after 1/3 = 0.33 seconds after the previous attack)
        //            SetTheTimer(ref nextAttackTime, attackRate);
        //        }
        //        //DEFLECT~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        //        //if the object is deflectable
        //        if (attackAreaScript.CanDeflect())
        //        {
        //            //if it is not deflectable
        //            IDeflectable deflectable = attackAreaScript.GetDeflectableObject();
        //            if (deflectable.Equals(null))
        //            {
        //            }
        //            else
        //            {
        //                deflectable.Deflect(transform.right);
        //            }

        //        }
        //    }
        //    //if V is pressed, defence

        //    //DEFENSE~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        //    if (Input.GetKeyDown(KeyCode.V) && IsAnActionGoingOn())
        //    {
        //        //pull up the shield!
        //        Defense();

        //        //set the nextdefense time ... second later
        //        SetTheTimer(ref nextDefenseTime, defenseRate);
        //    }

        //}

        private bool IsAnActionGoingOn() //return ture if any of these actions(attack,defense) is NOT taking place
        {

            return Time.time >= nextAttackTime && Time.time >= nextDefenseTime;
        }

        private void SetTheTimer(ref float nextActionTime, float actionRate)
        {
            nextActionTime = Time.time + 1f / actionRate;
        }

        //deflects objects with Ideflectable interface
        private void HandleDeflectable(IDeflectable deflectable)
        {
            Debug.Log("Deflecting object...");
            deflectable.Deflect(transform.right); // Perform deflection in the given direction
        }


        //perform attack action
        private void Attack()
        {
            // Trigger animation
            animator.SetTrigger("Attack");

            // Start coroutine to manage attack area visibility
            StartCoroutine(ManageAttackArea()); // Pass custom times as arguments
        }

        //perform defense action
        private void Defense()
        {
            //trigger animation
            animator.SetTrigger("Defence");

            //set activate defence mode
            StartCoroutine(ManageDefenseArea()); // Pass custom times as arguments
        }


        
        private IEnumerator ManageAttackArea() //makes it so attack area openes after some time and closes after some time
        {
            
            yield return new WaitForSeconds(attackStartDelay); // Wait for the specified delay before enabling the attack area
            attacking = true;
            attackArea.SetActive(attacking);

            
            yield return new WaitForSeconds(attackScope); // Wait for the specified delay before disabling the attack area
            attacking = false;
            attackArea.SetActive(attacking);
        }

        
        private IEnumerator ManageDefenseArea() //makes it so defense area openes after some time and closes after some time
        {
            
            yield return new WaitForSeconds(defenseStartDelay); // Wait for the specified delay before enabling the attack area
            defensing = true;
            defenseArea.SetActive(defensing);

            
            yield return new WaitForSeconds(defenseScope); // Wait for the specified delay before disabling the attack area
            defensing = false;
            defenseArea.SetActive(defensing);
        }
    }
}
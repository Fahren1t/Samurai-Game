using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator animator;

    public float attackRate = 3f;
    public float defenseRate = 3f;
    
    private float nextAttackTime = 0f;
    private float nextDefenseTime = 0f;

    private bool attacking = false;
    private bool defensing = false;
 
    private GameObject attackArea = default;
    private GameObject defenseArea = default;

    private AttackArea attackAreaScript;
    
    



    // Start is called before the first frame update
    void Start()
    {
        //makes the first object under the player is attack area
        attackArea = transform.GetChild(0).gameObject;
        //makes the second object under the player is defense area
        defenseArea = transform.GetChild(1).gameObject;

        attackAreaScript = attackArea.GetComponent<AttackArea>();
        attackAreaScript.OnDeflectableEntered += HandleDeflectable; // Subscribe to the event

       
        
    }

    // Update is called once per frame
    void Update()
    {
        


        
        if (Time.time >= nextAttackTime && Time.time >= nextDefenseTime)//Time.time is the time basicly. when the time is bigger than attack time, we attack.
        {
            
            

            //ATTACK~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            if (Input.GetKeyDown(KeyCode.Space))
            {

                Attack();
                //we set the next attack time = (current time) + (whatever the attack time is according to attack rate is)
                //(ex. if attack rate is 3 than attack time is after 1/3 = 0.33 seconds after the previous attack)
                nextAttackTime = Time.time + 1f / attackRate;             
            }
            //DEFLECT~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            if (attackAreaScript.CanDeflect())
            {

                IDeflectable deflectable = attackAreaScript.GetDeflectableObject();
                if (deflectable != null)
                {
                    deflectable.Deflect(transform.right);
                }
                
            }
        }
            //if V is pressed, defence
            
            //DEFENSE~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        if (Input.GetKeyDown(KeyCode.V) && Time.time >= nextAttackTime && Time.time >= nextDefenseTime)
        {
            
            Defense();

            nextDefenseTime = Time.time + 1f / defenseRate;
        }

    }

    //deflects objects with Ideflectable interface
    private void HandleDeflectable(IDeflectable deflectable)
    {
        Debug.Log("Deflecting object...");
        deflectable.Deflect(transform.right); // Perform deflection in the given direction
    }


    //performs attack action
    private void Attack()
    {
        // Trigger animation
        animator.SetTrigger("Attack");

        // Start coroutine to manage attack area visibility
        StartCoroutine(ManageAttackArea()); // Pass custom times as arguments
    }

    //performans defense action
    private void Defense()
    {
        //trigger animation
        animator.SetTrigger("Defence");

        //set activate defence mode
       StartCoroutine(ManageDefenseArea()); // Pass custom times as arguments
    }    

    
    //makes it so attack area openes after some time and closes after some time
    private IEnumerator ManageAttackArea()
    {
        // Wait for the specified delay before enabling the attack area
        yield return new WaitForSeconds(0.12f);
        attacking = true;
        attackArea.SetActive(attacking);

        // Wait for the specified delay before disabling the attack area
        yield return new WaitForSeconds(0.08f);
        attacking = false;
        attackArea.SetActive(attacking);
    }

    //makes it so defense area openes after some time and closes after some time
    private IEnumerator ManageDefenseArea()
    {
        // Wait for the specified delay before enabling the attack area
        yield return new WaitForSeconds(0f);
        defensing = true;
        defenseArea.SetActive(defensing);

        // Wait for the specified delay before disabling the attack area
        yield return new WaitForSeconds(1/ defenseRate);
        defensing = false;
        defenseArea.SetActive(defensing);
    }
}

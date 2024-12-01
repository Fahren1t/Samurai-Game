using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerAtack : MonoBehaviour
{
    
    public Animator animator;

    private GameObject attackArea = default;
    private atackArea attackAreaScript;

    private bool attacking = false;

    public float attackRate = 3f;
    private float nextAttackTime = 0f;


    // Start is called before the first frame update
    void Start()
    {
        //makes the first object of under the player is attack area
        attackArea = transform.GetChild(0).gameObject;
        attackAreaScript = attackArea.GetComponent<atackArea>();
        attackAreaScript.OnDeflectableEntered += HandleDeflectable; // Subscribe to the event
       
        /*
        // Assert that the attack area and script are correctly assigned
        Debug.Assert(attackArea != null, "Attack area GameObject is not assigned or missing!");
        Debug.Assert(attackAreaScript != null, "Attack area script is not found in the attack area GameObject!");
        // Ensure Animator is assigned
        Debug.Assert(animator != null, "Animator is missing in playerAtack script!");
        */
    }

    // Update is called once per frame
    void Update()
    {
        //hit = attackArea.GetComponent<RaycastHit2D>();


        attackArea.SetActive(attacking);
        if (Time.time >= nextAttackTime)//Time.time is the time basicly. when the time is bigger than attack time, we attack.
        {
            attacking = false;//make attackig false so that the attack area doesn't stay open.

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
                Debug.Log("can deflect");
                IDeflectable deflectable = attackAreaScript.GetDeflectableObject();
                if (deflectable != null)
                {
                    deflectable.Deflect(transform.right);
                }
                
            }
        }
    }
    private void HandleDeflectable(IDeflectable deflectable)
    {
        Debug.Log("Deflecting object...");
        deflectable.Deflect(transform.right); // Perform deflection in the given direction
    }
    private void Attack()
    {
        //trigger animation
        animator.SetTrigger("Attack");
        //damage enemy
        attacking = true;
        attackArea.SetActive(attacking);//set attackArea to active so that it appears
    }
}

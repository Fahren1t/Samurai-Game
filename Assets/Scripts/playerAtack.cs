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

    public RaycastHit2D hit;

    // Start is called before the first frame update
    void Start()
    {
        //makes the first object of under the player is attack area
        attackArea = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        //hit = attackArea.GetComponent<RaycastHit2D>();

        attacking = false;//make attackig false so that the attack area doesn't stay open.
        attackArea.SetActive(attacking);
        if (Time.time >= nextAttackTime)//Time.time is the time basicly. when the time is bigger than attack time, we attack.
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
            
            IDeflectable iDeflectable = attackAreaScript.GetDeflectableObject();
            //look if the object is deflectable
            if (attackAreaScript.CanDeflect() && iDeflectable != null)
            {
                //get the object and invoke deflect method
                iDeflectable.Deflect(transform.right);
            }
        }
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

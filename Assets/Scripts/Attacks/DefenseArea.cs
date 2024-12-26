using UnityEngine;

public class DefenseArea : MonoBehaviour
{
    public Animator animator;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Projectile")
        {

            Debug.Log("projectile Entered");
            Destroy(collider.gameObject);

            //play shield hit animation
            animator.SetTrigger("ShieldHit");
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        
    }
}

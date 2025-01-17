using UnityEngine;

namespace Game.PlayerScripts
{
    public class DefenseArea : MonoBehaviour
    {
        public Animator animator; //animator for playing animations

        private void OnTriggerEnter2D(Collider2D collider)
        {
            //if the tag of the entered object is "Projectile" than destroy that object
            if (collider.CompareTag("Projectile"))
            {

                Debug.Log("projectile Entered");
                Destroy(collider.gameObject);

                //trigger animation
                animator.SetTrigger("ShieldHit");
            }

        }
    }
}
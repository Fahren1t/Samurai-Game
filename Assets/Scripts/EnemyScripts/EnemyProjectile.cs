using Game.Scripts;
using UnityEngine;

namespace Game.EnemyScripts
{
    public class EnemyProjectile : MonoBehaviour, IDeflectable
    {
        [field: SerializeField] public float ReturnSpeed { get; set; } = 130f; //return speed of bullet after it has been deflected
                                public Collider2D enemyColl { get; set; } //gets the enemy collider

               [SerializeField] public int damageAmount = 5; //damage of particle

                                
                                private Collider2D BulletCollider; //gets the bullet collider

                                private IDamageable iDamagable;

                                private Rigidbody2D BulletRigidbody; //rigidbody of particle
    

        private void Start()
        {

            BulletCollider = GetComponent<Collider2D>(); //get collider of projectile
            BulletRigidbody = GetComponent<Rigidbody2D>(); //get ridgidbody of projectile

            //before starting, set the collison false so that enemy doesn't hurt himself
            IgnoreCollisionWithEnemyToggle();

            //destroy the arrow after 3 seconds
            Destroy(gameObject, 3);
        }

        //ignores the collision between enemy and projectile
        private void IgnoreCollisionWithEnemyToggle()
        {

            if (!Physics2D.GetIgnoreCollision(BulletCollider, enemyColl))
            {
                //turn on ignore collisions
                Physics2D.IgnoreCollision(BulletCollider, enemyColl, true);
            }

            else
            {
                //turn off ignore collision
                Physics2D.IgnoreCollision(BulletCollider, enemyColl, false);
            }

        }

        //deflect the particle
        public void Deflect(Vector2 deflectionDirection)
        {
            IgnoreCollisionWithEnemyToggle();
            // Instantly redirect with high force
            BulletRigidbody.linearVelocity = Vector2.zero; // Reset velocity
            BulletRigidbody.AddForce(deflectionDirection * ReturnSpeed, ForceMode2D.Impulse); // Apply force in the new direction

            // Flip the object horizontally to face the opposite direction
            transform.rotation = Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z + 180f);


        }
    }
}
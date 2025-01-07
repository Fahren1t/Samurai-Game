using UnityEngine;

public class EnemyProjectile : MonoBehaviour, IDeflectable
{
    [field : SerializeField] public float returnSpeed { get; set; } = 130f;
                             public Collider2D enemyColl { get; set; }
                             
                             private Collider2D coll;

            [SerializeField] public int damageAmount = 5;

                             private IDamageable iDamagable;

                             private Rigidbody2D rb;
    

    private void Start()
    {
        
        coll = GetComponent<Collider2D>(); //get collider of projectile
        rb = GetComponent<Rigidbody2D>(); //get ridgidbody of projectile

        //before starting, set the collison false so that enemy doesn't hurt himself
        IgnoreCollisionWithEnemyToggle();

        //destroy the arrow after 3 seconds
        Destroy(gameObject, 3);
    }




    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    // Consider adding null checks and logging
    //    iDamagable = collision.gameObject.GetComponent<IDamageable>();
    //    iDamagable?.Damage(damageAmount);
    //}




    //ignores the collision between enemy and projectile
    private void IgnoreCollisionWithEnemyToggle()
    {
        
        if(!Physics2D.GetIgnoreCollision(coll, enemyColl))
        {
            //turn on ignore collisions
            Physics2D.IgnoreCollision(coll, enemyColl,true);
        }

        else
        {
            //turn off ignore collision
            Physics2D.IgnoreCollision(coll, enemyColl, false);
        }
        
    }


    public void Deflect(Vector2 deflectionDirection)
    {
        IgnoreCollisionWithEnemyToggle();
        // Instantly redirect with high force
        rb.linearVelocity = Vector2.zero; // Reset velocity
        rb.AddForce(deflectionDirection * returnSpeed, ForceMode2D.Impulse); // Apply force in the new direction

        // Flip the object horizontally to face the opposite direction
        transform.rotation = Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z + 180f);

        
    }

    //public void Deflect(Vector2 direction)
    //{
    //    //make it so that projectile can hit enemy
    //    IgnoreCollisionWithEnemyToggle();

    //    //change projectile velocity
    //    rb.linearVelocity = direction * returnSpeed;
    //}
}

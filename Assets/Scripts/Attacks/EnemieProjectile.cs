using UnityEngine;

public class EnemieProjectile : MonoBehaviour, IDeflectable
{
    private IDamageable iDamagable;
    [SerializeField] private int damageAmount = 1;

    public Collider2D enemyColl { get; set; }

    [SerializeField] public float returnSpeed { get; set; } = 15f;

    private Collider2D coll;
    private Rigidbody2D rb;

    private void Start()
    {
        coll = GetComponent<Collider2D>();
        rb = GetComponent<Rigidbody2D>();


        IgnoreCollisionWithEnemyToggle();    
    }
    //on collision Damage
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Consider adding null checks and logging
        iDamagable = collision.gameObject.GetComponent<IDamageable>();
        iDamagable?.Damage(damageAmount);
    }

    //ignores the collision between enemy and projectile
    private void IgnoreCollisionWithEnemyToggle()
    {
        // Simplified collision toggling
        Physics2D.IgnoreCollision(coll, enemyColl, !Physics2D.GetIgnoreCollision(coll, enemyColl));
    }
    public void Deflect(Vector2 deflectionDirection)
    {
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

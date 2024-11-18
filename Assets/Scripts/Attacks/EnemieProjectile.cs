using UnityEngine;

public class EnemieProjectile : MonoBehaviour, IDeflectable
{
    private IDamageable iDamagable;
    [SerializeField] private int damageAmount = 1;

    public Collider2D enemyColl { get; set; }
    [SerializeField] public float returnSpeed { get; set; } = 10f;

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
        iDamagable = collision.gameObject.GetComponent<IDamageable>();
        if (iDamagable != null)
        {
            //Damage
            iDamagable.Damage(damageAmount);
        }
    }
    private void IgnoreCollisionWithEnemyToggle()
    {
        if (!Physics2D.GetIgnoreCollision(coll, enemyColl))
        {
            Physics2D.IgnoreCollision(coll, enemyColl, true);
        }
        else
        {
            Physics2D.IgnoreCollision(coll, enemyColl, false);
        }
    }

    public void Deflect(Vector2 direction)
    {
        //make it so that projectile can hit enemy
        IgnoreCollisionWithEnemyToggle();

        //change projectile velocity
        rb.linearVelocity = direction * returnSpeed;
    }
}

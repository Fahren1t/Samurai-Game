using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] private Rigidbody2D bulletPrefab;
    [SerializeField] private float timeBtwAttacks = 2f;
    [SerializeField] public float bulletSpeed = 15f;
    private float shootTimer;

    private Rigidbody2D bulletRB;

    private EnemyProjectile enemyProjectile;

    private Collider2D coll;

    void Start()
    {
        //set collider
        coll = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //update timer
        shootTimer += Time.deltaTime;

        if (shootTimer >= timeBtwAttacks)
        {
            //reset timer
            shootTimer = 0;

            //shoot projectile
            Shoot();
        }

    }

    private void Shoot()
    {

        // Calculate the rotation for the bullet (90 degrees on the Z-axis relative to the shooter)
        Quaternion bulletRotation = transform.rotation * Quaternion.Euler(0, 0, 90);
        //spawn a bullet

        bulletRB = Instantiate(bulletPrefab, transform.position, bulletRotation);

        //set bullet's velocity
        bulletRB.linearVelocity = -transform.right * bulletSpeed;

        //gra reference to the enemyProjectile 
        enemyProjectile = bulletRB.gameObject.GetComponent<EnemyProjectile>();

        enemyProjectile.enemyColl =  coll;
    }
}
using UnityEngine;

public class PlayerHealth : Health, IDamageable
{

    private int damageAmount;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        

        if(collider.tag == "Projectile" && collider.GetComponent<EnemyProjectile>() != null)
        {
            damageAmount = collider.GetComponent<EnemyProjectile>().damageAmount;
            Damage(damageAmount);
            Debug.Log("player got damaged");


        }
    }
    
}

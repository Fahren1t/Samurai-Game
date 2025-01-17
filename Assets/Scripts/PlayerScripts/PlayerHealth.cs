using UnityEngine;
using Game.Scripts;
using Game.EnemyScripts;

namespace Game.PlayerScripts
{
    
    public class PlayerHealth : Health, IDamageable 
    {
        
                         
        private int damageAmount;//damage amount received from the entered object

        private void OnTriggerEnter2D(Collider2D collider)
        {

            //if the entered objects tag is "Projectile" and if it has "EnemyProjectile" script attached to it, damage enemy
            if (collider.CompareTag("Projectile") && !collider.GetComponent<EnemyProjectile>().Equals(null))
            {
                damageAmount = collider.GetComponent<EnemyProjectile>().damageAmount;
                Damage(damageAmount);
                Debug.Log("player got damaged");


            }
        }

    }
}
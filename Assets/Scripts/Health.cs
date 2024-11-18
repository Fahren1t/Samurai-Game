using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour, IDamageable
{
    [SerializeField] private int health = 1;
    //[SerializeField] private ParticleSystem damageParticles;
    public void Damage(int amount)
    {
        if (health != 0)
        {
            this.health -= amount;

            //Instantiate(damageParticles, transform.position, Quaternion.identity);
        }
        if (health <= 0)
        {
            Die();
        }
    }
   private void Die()
    {
        Debug.Log("I am Dead!");
        Destroy(this.gameObject); 

    }
}

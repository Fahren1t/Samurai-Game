using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
  [SerializeField] private int health = 1;

    public void Damage(int amount)
    {
        if (health != 0) 
        { 
            this.health -= amount;
        }
        if(health <= 0)
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

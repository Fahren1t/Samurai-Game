using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
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
//public class HealthTests
//{
//    [Test]
//    public void DamageReducesHealth()
//    {
//        // Arrange
//        var healthObj = new GameObject();
//        var health = healthObj.AddComponent<Health>();
//        health.Damage(1); // Assuming default health is 1 from the class

//        // Act & Assert
//        Assert.IsNull(healthObj, "GameObject should be destroyed after health reaches 0.");
//    }
//}
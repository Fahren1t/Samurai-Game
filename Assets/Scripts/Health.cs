using UnityEngine;

namespace Game.Scripts
{
    public class Health : MonoBehaviour
    {
        [SerializeField] public int health = 1; // Assuming a default health value

        //damage the object carrying this or child scripts 
        public void Damage(int amount)
        {
            if (!health.Equals(0))
            {
                health -= amount;

                //Instantiate(damageParticles, transform.position, Quaternion.identity);
            }
            if (health <= 0)
            {
                Die();
            }
        }

        //destroy the objects carrying this or child scripts
        private void Die()
        {
            #if UNITY_EDITOR
            Object.DestroyImmediate(gameObject);
            #else
            Object.Destroy(gameObject);
            #endif

            Debug.Log("I am Dead!");
        }
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
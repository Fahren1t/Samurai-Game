using System;
using UnityEngine;
using Game.EnemyScripts;
using Game.Scripts;

namespace Game.PlayerScripts
{
    public class AttackArea : MonoBehaviour
    {
        private readonly int damage = 1; //damage of the player

        private EnemyHealth enemyHealth; //get the health of enemy

        private readonly bool canDeflect = false;  // Add this variable to track deflectable objects
        private readonly GameObject currentDeflectableObject = null;  // To store the reference to deflectable object

        public event Action<IDeflectable> OnDeflectableEntered; // Event to notify deflectable objects




        public void OnTriggerEnter2D(Collider2D collider)
        {
            //check the health condition
            if (!collider.GetComponent<EnemyHealth>().Equals(null))
            {
                enemyHealth = collider.GetComponent<EnemyHealth>();
                enemyHealth.Damage(damage); //damage enemy
            }

            // Check for IDeflectable interface
            if (collider.TryGetComponent<IDeflectable>(out var deflectable))
            {
                Debug.Log("Deflectable object entered");
                OnDeflectableEntered?.Invoke(deflectable); // Notify the playerAtack script

            }
            

        }

        // Getter method to get the current deflectable object
        public bool CanDeflect() => canDeflect;

        //pass the interface 
        public IDeflectable GetDeflectableObject()
        {
            return !currentDeflectableObject.Equals(null)
                ? currentDeflectableObject.GetComponent<IDeflectable>() : null;
        }

    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class AttackArea : MonoBehaviour
{
    private int damage = 1;

    private bool canDeflect = false;  // Add this variable to track deflectable objects
    private GameObject currentDeflectableObject = null;  // To store the reference to deflectable object
    public event Action<IDeflectable> OnDeflectableEntered; // Event to notify deflectable objects

    private void OnTriggerEnter2D(Collider2D collider)
    {
        //check the health condition
        if (collider.GetComponent<Health>() != null)
        {
            Health health = collider.GetComponent<Health>();
            health.Damage(damage);
        }
        



        // Check for IDeflectable interface
        IDeflectable deflectable = collider.GetComponent<IDeflectable>();
        if (deflectable != null)
        {
            Debug.Log("Deflectable object entered");
            OnDeflectableEntered?.Invoke(deflectable); // Notify the playerAtack script
        
        }
       /*
        // Check for IDeflectable interface
        IDeflectable deflectable = collider.GetComponent<IDeflectable>();
        if (deflectable != null)
        {
            canDeflect = true;
            currentDeflectableObject = collider.gameObject;

            Debug.Log(" object entered");

            // Reset deflectable status when object exits the trigger
            canDeflect = false;
            currentDeflectableObject = null;
        }
       */

    }
    // Getter method to get the current deflectable object
    public bool CanDeflect() => canDeflect;

    public IDeflectable GetDeflectableObject()
    {
        return currentDeflectableObject != null
            ? currentDeflectableObject.GetComponent<IDeflectable>() : null;
    } 
    
}
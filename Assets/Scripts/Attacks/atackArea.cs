using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class atackArea : MonoBehaviour
{
    private int damage = 1;

    private bool canDeflect = false;  // Add this variable to track deflectable objects
    private GameObject currentDeflectableObject = null;  // To store the reference to deflectable object


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
            canDeflect = true;
            currentDeflectableObject = collider.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        // Reset deflectable status when object exits the trigger
        if (collider.gameObject == currentDeflectableObject)
        {
            canDeflect = false;
            currentDeflectableObject = null;
        }
    }
    // Getter method to check if there's a deflectable object
    public bool CanDeflect()
    {
        return canDeflect;
    }

    // Getter method to get the current deflectable object
    public IDeflectable GetDeflectableObject()
    {
        return currentDeflectableObject.GetComponent<IDeflectable>();
    }
}
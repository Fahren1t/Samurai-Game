using Game.EnemyScripts;
using NUnit.Framework;
using UnityEngine;
using Game.Scripts;

public class EnemyHealthTest
{
    private const int amount = 1;


    //check if enemy health is 1 default
    [Test]
    public void IsEnemyHeathOne()
    {
        //ACT
        var enemy = new GameObject().AddComponent<EnemyHealth>();

        int health = enemy.health;
        //ASSERT
        Assert.AreEqual(1, health);

    }


    //test if damage reduces health
    [Test]
    public void DamageReducesHealth()
    {
        // Arrange
        var health = new GameObject().AddComponent<Health>();
        int _health = health.health;

        health.Damage(amount); // Assuming default health is 1 from the class

        // Act & Assert
        Assert.AreEqual(health.health, _health - amount);
    }


    //check if die function works
    [Test]
    public void DieDestroysGameObject()
    {
        // Arrange
        var health = new GameObject().AddComponent<Health>();
        health.health = 1;
        // Act
        health.Damage(1);

        // Assert
        Assert.IsTrue(health == null);
    }


}

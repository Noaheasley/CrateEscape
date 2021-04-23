using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBehaviour : MonoBehaviour
{
    [Tooltip("Sets the health of the actor.")]
    [SerializeField]
    private float _health;
    [Tooltip("Destroys the actor on death.")]
    [SerializeField]
    private bool _destroyOnDeath = true;
    //getter and setter for health
    public float Health
    {
        get
        {
            return _health;
        }
    }

    /// <summary>
    /// Subtracts the given damage value from the health
    /// </summary>
    /// <param name="damage"></param>
    public void TakeDamage(float damage)
    {
        _health -= damage;

        if (_health < 0)
            _health = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //If the object health is lower or equal to 0, destroy the object
        if (_health <= 0 && _destroyOnDeath)
            Destroy(gameObject);
        //checks if the health is at zero if so the game object will not be active
        else if (_health <= 0)
            gameObject.SetActive(false);
    }
}

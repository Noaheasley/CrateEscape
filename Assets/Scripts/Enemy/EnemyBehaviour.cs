using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [Tooltip("How much damage this enemy will do to the target it touches.")]
    [SerializeField]
    private float _damage;
    private EnemyMovementBehaviour _movement;

    private void Awake()
    {
        //Grabs a refrence to movement behaviour in order to get the enemy's target
        _movement = GetComponent<EnemyMovementBehaviour>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        //If the target isn't the target return
        if (collision.gameObject != _movement.Target)
            return;

        //Get a reference to the attached health script
        HealthBehaviour health = collision.gameObject.GetComponent<HealthBehaviour>();

        //If the health isn't null, deal damage
        if (health)
            health.TakeDamage(_damage);
    }
}

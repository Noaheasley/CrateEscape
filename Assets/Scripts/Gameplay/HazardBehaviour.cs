using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardBehaviour : MonoBehaviour
{
    [Tooltip("How much damage the object will do to the target it touches.")]
    [SerializeField]
    private float _damage;

    [Tooltip("How Fast the trap will travel.")]
    [SerializeField]
    private float _speed;

    [Tooltip("How long till the trap comes out.")]
    [SerializeField]
    private float _time = 10.0f;

    [Tooltip("Countdown for the timer to bring out the trap.")]
    [SerializeField]
    private float _countDownOut = 6.0f;

    [Tooltip("Countdown for the timer to pull in the trap.")]
    [SerializeField]
    private float _countDownIn = 6.0f;

    private void OnCollisionEnter(Collision collision)
    {
        //Get a reference to the attached health script
        HealthBehaviour health = collision.gameObject.GetComponent<HealthBehaviour>();

        //If the health isn't null, deal damage
        if (health)
            health.TakeDamage(_damage);
    }
    void Update()
    {
        
        _countDownOut -= Time.deltaTime;
        transform.position += transform.forward * Time.deltaTime * _speed;
        if(_countDownOut <= 0.0f)
        {
            transform.position -= transform.forward * Time.deltaTime * _speed;
            timerEnded();
        }
    }

    void timerEnded()
    {
        _countDownIn -= Time.deltaTime;
        transform.position -= transform.forward * Time.deltaTime * _speed;
        if(_countDownIn <= 0.0f)
        {
            _countDownOut = _time;
            _countDownIn = _time;
        }
    }
}

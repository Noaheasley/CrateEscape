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
        //Countdown for the hazard to move out that uses delta time
        _countDownOut -= Time.deltaTime;
        //as the timer counts down the hazard will move forward
        transform.position += transform.forward * Time.deltaTime * _speed;
        //if the countdown reaches zero the object will stop moving
        if(_countDownOut <= 0.0f)
        {
            //stops the object from moveing by having the object move forward and backwards at the same time
            transform.position -= transform.forward * Time.deltaTime * _speed;
            //calls time ended function
            timerEnded();
        }
    }
    //once the timer ends in update this will run
    void timerEnded()
    {
        //Countdown for the hazard to move in that uses delta time
        _countDownIn -= Time.deltaTime;
        //object moves backwards
        transform.position -= transform.forward * Time.deltaTime * _speed;
        //once the countdown runs out of time it resets both timers and repeat
        if(_countDownIn <= 0.0f)
        {
            //timers reset
            _countDownOut = _time;
            _countDownIn = _time;
        }
    }
}

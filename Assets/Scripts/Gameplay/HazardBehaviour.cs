using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardBehaviour : MonoBehaviour
{
    [Tooltip("How much damage the object will do to the target it touches.")]
    [SerializeField]
    private float _damage;

    public float XMin;
    public float XMax;

    public float Speed;

    public float StartCos = 0;
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
        StartCos += Time.deltaTime;
        transform.position += new Vector3(Mathf.Cos(StartCos), transform.position.y, transform.position.z) * Speed * Time.deltaTime;
    }
}

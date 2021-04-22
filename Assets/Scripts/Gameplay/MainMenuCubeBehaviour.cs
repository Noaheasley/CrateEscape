using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuCubeBehaviour : MonoBehaviour
{
    public float x = 1.0f;
    public float y = 1.0f;
    public float z = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(x,y,z);
    }
}

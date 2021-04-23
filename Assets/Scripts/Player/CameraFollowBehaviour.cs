using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowBehaviour: MonoBehaviour
{
    public GameObject player;

    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        //sets the offset to be the cameras position minus the players position
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //sets the camera's postion to be the player's positon
        transform.position = player.transform.position + offset;
    }
}

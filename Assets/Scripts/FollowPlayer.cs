using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //Reference Vehicle
    public GameObject player;
    //Position of the camera behind of the vehicle
    private Vector3 offset = new Vector3(0, 4.8f, -6.01f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // LateUpdate is called after Update of the Vehicle
    void LateUpdate()
    {
        //Camera following player taking the position of the vehicle
        transform.position = player.transform.position + offset;
    }
}

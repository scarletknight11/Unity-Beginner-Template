using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    Vector3 followcam;
    Vector3 newpos;
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        followcam = player.transform.position-transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        newpos = transform.position;
        newpos.x=player.transform.position.x - followcam.x;
        newpos.z = player.transform.position.z - followcam.z;
        transform.position = newpos;    
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Allows us to access Vertical access from input manager that predefines our input control and multiples movement by speed for Forward and Backward direction
        float vertical = Input.GetAxis("Vertical") * speed;
        //Translates our movement
        transform.Translate(0,0, vertical * Time.deltaTime);
        //Allows us to access Horizontal access from input manager that predefines our input control and multiples movement by speed for Up and Down direction
        float horizontal = Input.GetAxis("Horizontal") * speed;
        //Translates our movement
        transform.Translate(horizontal * Time.deltaTime, 0, 0);

    }
}

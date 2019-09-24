using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20f;
    private float turnSpeed = 45f;
    private float horizontalInput;
    private float forawrdInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per second
    void Update()
    {
        forawrdInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        //We'll move the vehicle forward based on verticle input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forawrdInput);
        //Turn the vehicle based on horizontal input
        transform.Rotate(Vector3.up, horizontalInput * turnSpeed * Time.deltaTime);
    }
}

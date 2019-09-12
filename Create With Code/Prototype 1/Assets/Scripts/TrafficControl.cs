using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per second
    void Update()
    {
        //We'll move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * 25);
    }
}

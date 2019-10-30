using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    //public float time = (4f);
    public float delay = 0.5f;
    public float firerate = 0.5f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > delay)
        {
            delay = Time.time + firerate;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            //StartCoroutine(wait());  
        }
        //IEnumerator wait()
            {
          //      yield return new WaitForSeconds(time);
            }
    }
}

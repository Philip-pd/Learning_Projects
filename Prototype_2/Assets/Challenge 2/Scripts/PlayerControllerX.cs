using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float Delay=0;

    // Update is called once per frame
    void Update()
    {
        if (Delay > 0)
        { Delay-=(1*Time.deltaTime); }
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Delay<=0)
        {
            Delay = 1f;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
        
    }
}

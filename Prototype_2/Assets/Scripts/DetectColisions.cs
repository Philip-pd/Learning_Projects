using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectColisions : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}

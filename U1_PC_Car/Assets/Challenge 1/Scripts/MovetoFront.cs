using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovetoFront : MonoBehaviour
{
    public GameObject plane;
    public float distance=140;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (plane.transform.position.z >= transform.position.z +distance)
        {
           Vector3 vec = new Vector3( transform.position.x, transform.position.y, transform.position.z+200 );
            transform.position = vec;
        }
    }
}

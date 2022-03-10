using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Envspin : MonoBehaviour
{
    public float RotationSpeed;
    public GameObject plane;
    private float playerpos=0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float dir;
        dir = plane.transform.position.z-playerpos;
        playerpos = plane.transform.position.z;
        transform.Rotate(Vector3.up * RotationSpeed * Time.deltaTime* dir);
    }
}

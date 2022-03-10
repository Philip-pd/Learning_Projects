using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;
    private float topBound = 30;
    private float bottomBound = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward*Time.deltaTime*speed);
        if(transform.position.z > topBound )
        {
            Destroy(gameObject);   
        }
        if(transform.position.z < bottomBound )
        {
            Debug.Log("GameOver");
            Destroy(gameObject);
        }
    }
}

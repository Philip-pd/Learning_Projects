using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput; //why public?
    private float verticalInput;
    private float speed=20.0f;
    public float Range=10;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x<-Range)
        {
            transform.position = new Vector3(-10,transform.position.y,transform.position.z);
        }
        if (transform.position.x > Range)
        {
            transform.position = new Vector3(10, transform.position.y, transform.position.z);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        if(Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed*0.5f);
        }
        else
        {

        transform.Translate(Vector3.right*horizontalInput*Time.deltaTime*speed);
        }
    }
}

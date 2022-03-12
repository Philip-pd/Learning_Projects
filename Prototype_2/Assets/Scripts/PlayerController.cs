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
    public GameObject projectilePrefab2;


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
        
        horizontalInput = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(projectilePrefab2, transform.position, projectilePrefab.transform.rotation);
            }
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed*0.5f);
        }else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            }
            transform.Translate(Vector3.right*horizontalInput*Time.deltaTime*speed);
        }
    }
}

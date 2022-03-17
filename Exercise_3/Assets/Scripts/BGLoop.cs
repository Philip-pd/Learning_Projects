using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGLoop : MonoBehaviour
{
    private Vector3 startPos;
    private float speed = 30;
    private float repeatWidth;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        startPos = transform.position;
        repeatWidth=GetComponent<BoxCollider>().size.x/2;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {

            transform.Translate(Vector3.left * Time.deltaTime * speed);
            if (transform.position.x < startPos.x-repeatWidth)
            {
                transform.position = startPos;
            }
        }
    }
}

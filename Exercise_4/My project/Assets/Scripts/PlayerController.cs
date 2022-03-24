using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed = 5.0f;
    private float powerupstrength=15f;
    private GameObject focalPoint;
    public GameObject PowerupIndicator;
    private bool hasPowerup;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        PowerupIndicator.transform.position=transform.position+new Vector3(0,-.5f,0);
        float forwardinput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * speed * forwardinput);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Powerup"))
        {
            hasPowerup = true;
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountDownRoutine());
            PowerupIndicator.SetActive(true);
        }
    }

    IEnumerator PowerupCountDownRoutine()
    {
        yield return new WaitForSeconds(7);
        hasPowerup=false;
        PowerupIndicator.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy")&&hasPowerup)
        {
            Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer=(collision.gameObject.transform.position - transform.position);
            Debug.Log("Collided with "+collision.gameObject.name+" with powerup set to "+hasPowerup);
            enemyRigidbody.AddForce(awayFromPlayer*powerupstrength,ForceMode.Impulse);
        }
    }

}

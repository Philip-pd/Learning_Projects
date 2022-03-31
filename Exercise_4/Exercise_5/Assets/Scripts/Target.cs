using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private float minSpeed = 12f;
    private float maxSpeed = 16f;
    private float maxTorque = 10f;
    private float xRange = 4f;
    private float ySpawnpos = -6f;
    private Rigidbody rb;
    private GameManager gameManager;
    public int pointValue;
    public ParticleSystem explosionParticle;


    // Start is called before the first frame update
    void Start()
    {
        gameManager=GameObject.Find("Game Manager").GetComponent<GameManager>();
        rb = GetComponent<Rigidbody>();
        rb.AddForce(RandomForce(),ForceMode.Impulse);
        rb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
        transform.position = RandomSpawnPos();
    }

    private Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-xRange, xRange), ySpawnpos);
    }

    private float RandomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }

    private Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }
    private void OnMouseDown()
    {
        Destroy(gameObject);
        gameManager.UpdateScore(pointValue);
        Instantiate(explosionParticle,transform.position,explosionParticle.transform.rotation);
        if (gameObject.CompareTag("Bad"))
        {
            gameManager.GameOver();
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        
        if(!gameObject.CompareTag("Bad"))
        {
           gameManager.GameOver();
        }
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

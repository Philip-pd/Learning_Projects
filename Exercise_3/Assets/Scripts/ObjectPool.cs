using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool SharedInstance;
    public List<GameObject> pooledObjects;
    public GameObject objectToPool;
    public int amountToPool;
    private float startDelay = 2f;
    private float repeatRate = 1;
    private PlayerController playerControllerScript;



    void Awake()
    {
        SharedInstance = this;
    }
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();

        pooledObjects = new List<GameObject>();
        GameObject tmp;
        for (int i = 0; i < amountToPool; i++)
        {
            tmp = Instantiate(objectToPool);
            tmp.SetActive(false);
            pooledObjects.Add(tmp);
        }
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        return null;
    }

    void SpawnObstacle()
    {
        GameObject obstacle = GetPooledObject();
        if(obstacle != null && playerControllerScript.gameOver == false)
        {
            obstacle.transform.position = this.transform.position;
            obstacle.transform.rotation = this.transform.rotation;
            obstacle.SetActive(true);
        }
    }
}

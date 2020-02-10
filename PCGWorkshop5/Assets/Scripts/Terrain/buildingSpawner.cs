using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildingSpawner : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public Transform spawnPos;
    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("spawnPoint"); //Finds object with tag

    
        for (int j = 0; j < spawnPoints.Length; j++)
        {
            for (int i = 0; i < 6; i++)
            {
                spawnPos.position = transform.position + new Vector3(Random.Range(-100, 300), 0, Random.Range(-100, 300));
                Instantiate(spawnPos, spawnPos.position, spawnPos.rotation);    //Creates a vector3 with random x and random z and applies to
                Instantiate(spawnPoints[j], spawnPos.position, spawnPos.rotation);  //the game object                
            }
               
        }
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemAreaSpawner : MonoBehaviour
{
    public GameObject spawnArea;

    public float width = 10;
    public float length = 10;
    public float height = 0;

    // Start is called before the first frame update
    void Start()
    {
         int itemsToSpawn = Random.Range(5, 10); //Chooses a number between 5 and 10.
        for (int i = 0; i <  itemsToSpawn; i++) //Loops through as many loops as chosen by the int.
        {

            Vector3 randPosition = new Vector3(Random.Range(-width, width), height, 
            Random.Range(-length, length)) + transform.position; //Creates a vector3 to a number within the range of -10 and 10 

            GameObject clone = Instantiate(spawnArea, randPosition, spawnArea.transform.rotation); 
            //Creates a gameobject and instantiates it to the public gameobject using the 
            //transform and position of randPosition and the rotation of the public gameobject.



        }
    }

}

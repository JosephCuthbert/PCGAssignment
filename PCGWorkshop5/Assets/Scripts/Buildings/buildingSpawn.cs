using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


[RequireComponent(typeof(MeshFilter))]
public class buildingSpawn : MonoBehaviour
{

    public GameObject[] homeObject;

    public int width = 10;  
    public int length = 10;
    public float height = 0.5f;

    public float raycastDistance = 100f;

    private int result;
    private Quaternion spawnRotation;

    void Start()
    {


        RaycastHit hit;

        if (Physics.Raycast(transform.position, Vector3.down, out hit, raycastDistance))
        {
            spawnRotation = Quaternion.FromToRotation(Vector3.up, hit.normal);
        }


        for (int i = 0; i < 6; i++)
       {

            for (int j = 0; j < 6; j++)
            {
                float seed = Random.Range(1,100);
                 result = (int)(Mathf.PerlinNoise(width / 10.0f + seed, length / 10.0f + seed) * 10);
                
                //Number of buildings
                //And type

                //j = width
                //i = length

                //Buildiings positioning

                // spawnArea.transform.position = new Vector3(Random.Range(1, 450),height, Random.Range(1, 450));
                /* Vector3 randPosition = new Vector3(Random.Range(-width, width), Random.Range(-height, height),
               Random.Range(-length, length)) + transform.position;*/

            }
       }

       

        if (result < 2)
        {
              Instantiate(homeObject[0], hit.point, spawnRotation);

            // homeObject[0].transform.Rotate(0, Random.Range(1, 100), 0);
        }
        else if (result < 4)
        {
             Instantiate(homeObject[1], hit.point, spawnRotation);

        }
        else if (result < 6)
        {
             Instantiate(homeObject[2], hit.point, spawnRotation);
            //Instantiate(homeObject[2], pos, Quaternion.identity);
            // homeObject[2].transform.Rotate(0, Random.Range(1, 100), 0);
        }
        else if (result < 8)
        {
              Instantiate(homeObject[3], hit.point, spawnRotation);
            // homeObject[3].transform.Rotate(0, Random.Range(1, 100), 0);
        }
        else if (result < 10)
        {
            Instantiate(homeObject[4], hit.point, spawnRotation);
            Instantiate(homeObject[5], hit.point, spawnRotation);
            // homeObject[3].transform.Rotate(0, Random.Range(1, 100), 0);
        }
      
    }
  

}

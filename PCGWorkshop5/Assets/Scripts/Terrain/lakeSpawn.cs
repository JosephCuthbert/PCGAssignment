using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lakeSpawn : MonoBehaviour
{

    public Transform lake;
    // Start is called before the first frame update
    void Start()
    {

        lake.position = transform.position + new Vector3(Random.Range(-100, 300), 0, Random.Range(-100, 300));

        for (int i = 0; i < 1; i++)
        {
            Instantiate(lake, lake.position, transform.rotation);
        }  
    }

}

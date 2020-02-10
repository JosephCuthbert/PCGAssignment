using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour
{
    public float height;
    public Transform[] environmentObjects;
    public Transform objectPos;
    // Start is called before the first frame update
    void Start()
    {
        for (int j = 0; j < environmentObjects.Length; j++)
        {
            for (int i = 0; i < 8; i++)
            {

                objectPos.position = transform.position + new Vector3(Random.Range(-50, 300), height, Random.Range(-50, 300));
                Instantiate(objectPos, objectPos.position, objectPos.rotation);
                Instantiate(environmentObjects[j], objectPos.position, objectPos.rotation);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

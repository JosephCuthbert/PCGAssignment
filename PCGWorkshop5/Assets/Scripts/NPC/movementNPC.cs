using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementNPC : MonoBehaviour
{
    public float speed = 2.0f;

    void Update()
    {
        // Can move the NPC side to side as if it were wandering, however
        // it does teleport the NPC to x-position '0'.
        /*
           float right = Mathf.PerlinNoise((Time.time * xScale),0.0f);

           Vector3 pos = transform.position;
           pos.x = right;
           transform.position = pos;
       */

        //Moves the player along like its wandering and does not teleport it to x-position '0'
        transform.Rotate(new Vector3(0, Random.Range(-70, 70), 0) * Time.deltaTime * 2);

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}

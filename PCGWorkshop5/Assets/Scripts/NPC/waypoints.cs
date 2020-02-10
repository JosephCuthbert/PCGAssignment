using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypoints : MonoBehaviour
{
    public float actualSpeed = 10.0f;
    public GameObject[] checkpoints;
    int counter = 0;
    public float distance = 2.0f; //on which distance you want to switch to the next waypoint
    void FixedUpdate()
    {
        Vector3 direction = Vector3.zero;
        //get the vector from your position to current waypoint

        checkpoints = GameObject.FindGameObjectsWithTag("WayPoint" );

       direction = checkpoints[counter].transform.position - transform.position;

        //check our distance to the current waypoint, Are we near enough?
        if (direction.magnitude < distance)
        {
            if (counter < checkpoints.Length - 1) //switch to the nex waypoint if exists
            {
                counter++;
            }
            else //begin from new if we are already on the last waypoint
            {
                counter = 0;
            }
        }
        direction = direction.normalized;
       

        GetComponent<Rigidbody>().velocity = new Vector3(direction.x * actualSpeed, direction.y * actualSpeed, direction.z * actualSpeed);
    }
}

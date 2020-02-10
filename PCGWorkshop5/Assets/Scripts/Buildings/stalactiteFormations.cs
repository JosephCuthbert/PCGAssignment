using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stalactiteFormations : MonoBehaviour
{

    //Creates arrays for the stalactites
    public GameObject[] stalactiteBase;
    public GameObject[] stalactiteMid;
    public GameObject[]  stalactiteTip;

    //Creates arrays for the stalagmites 
    public GameObject[] stalagmiteBase;
    public GameObject[] stalagmiteMid;
    public GameObject[] stalagmiteTip;

    public Transform spawnPos;

    // Start is called before the first frame update
    void Start()
    {


      
        for (int i = 0; i < 30; i++)
        {
            int stalacBase = Random.Range(0, stalagmiteBase.Length); 
            int stalacMid = Random.Range(0, stalagmiteMid.Length);  //Assigns an integer to the a random number within the stalagmite arrays.
            int stalacTip = Random.Range(0, stalagmiteTip.Length);


            spawnPos.position = transform.position + new Vector3(Random.Range(-100, 300), -50, Random.Range(-100, 300)); 
            //The spawnPos transform is equal to a random variable on the X and Z axis and -50 on the Y.
            Instantiate(spawnPos, spawnPos.position, spawnPos.rotation);
            //Instantiates the transform so that the gameobjects have a spawnpoint to instantiate one.

            Instantiate(stalagmiteBase[stalacBase], spawnPos.position, spawnPos.rotation);
            Instantiate(stalagmiteMid[stalacMid], spawnPos.position, spawnPos.rotation); //Instantiates the array with the chosen model piece, 
            Instantiate(stalagmiteTip[stalacTip], spawnPos.position, spawnPos.rotation);//then assings the above Transforms position and rotation
        }

        spawnPos.rotation *= Quaternion.Euler(0,0,180); //Flips the Transforms rotation by 180 degrees on the Z axis.sn
        for(int i = 0; i < 30; i++)
        {
            int stalacBase = Random.Range(0, stalactiteBase.Length);
            int stalacMid = Random.Range(0, stalactiteMid.Length); //Assigns an integer to the a random number within the stalactite arrays.
            int stalacTip = Random.Range(0, stalactiteTip.Length);


            spawnPos.position = transform.position + new Vector3(Random.Range(-100, 300), 65, Random.Range(-100, 300));
            Instantiate(spawnPos, spawnPos.position, spawnPos.rotation);


            Instantiate(stalactiteBase[stalacBase], spawnPos.position, spawnPos.rotation);
            Instantiate(stalactiteMid[stalacMid], spawnPos.position, spawnPos.rotation);
            Instantiate(stalactiteTip[stalacTip], spawnPos.position, spawnPos.rotation);
        }
    }
}


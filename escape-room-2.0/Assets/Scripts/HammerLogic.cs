using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerLogic : MonoBehaviour {

    public GameObject cubePiece1;
    public GameObject cubePiece2;
    public GameObject cubePiece3;
    public GameObject doorCode;
    private int counter = 0;
    public GameObject brick1;
    public GameObject brick2;
    public GameObject brick3;
    public GameObject x;
    private int wallCounter = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Cube")
        {
            counter++;
            Vector3 spawnLoc = other.ClosestPoint(transform.position);
            Quaternion spawnRot = Random.rotation;
            Instantiate(cubePiece1, spawnLoc, spawnRot);
            spawnRot = Random.rotation;
            Instantiate(cubePiece2, spawnLoc, spawnRot);
            spawnRot = Random.rotation;
            Instantiate(cubePiece3, spawnLoc, spawnRot);
            Destroy(other.gameObject);
            if (counter == 3)
            {
                doorCode.SetActive(true);
            }
        }  

        if (other.name == "WallN (1)")
        {
            wallCounter++;
            Vector3 spawnLoc = other.ClosestPoint(transform.position);
            Vector3 offset = new Vector3(0, 0, -1);
            spawnLoc = spawnLoc + offset;
            Quaternion spawnRot = Random.rotation;
            Instantiate(brick1, spawnLoc, spawnRot);
            spawnRot = Random.rotation;
            spawnLoc = spawnLoc + offset;
            Instantiate(brick2, spawnLoc, spawnRot);
            spawnRot = Random.rotation;
            spawnLoc = spawnLoc + offset;
            Instantiate(brick3, spawnLoc, spawnRot);
            if (wallCounter == 4)
            {
                Destroy(other.gameObject);
                x.SetActive(false);
            }
        }

        
        Debug.Log(other.name);
    }
}

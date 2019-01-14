using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerLogic : MonoBehaviour {

    public GameObject cubePiece1;
    public GameObject cubePiece2;
    public GameObject cubePiece3;
    public GameObject doorCode;
    private int counter = 0;

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
        }
    }
}

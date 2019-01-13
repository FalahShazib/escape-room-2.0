using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerSelect : MonoBehaviour {

    public float laserWidth = 0.1f;
    public float length = 10f;

	// Use this for initialization
	void Start () {

        Vector3[] initLaserPositions = new Vector3[ 2 ] {  Vector3.zero, Vector3.zero};
        //laserLine.SetPositions(initLaserPositions);
        //laserLine.SetWidth(laserWidth, laserWidth);
		
	}

	// Update is called once per frame
	void Update () {
		if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        {
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit raycastHit;
            Vector3 endPosition = transform.position + (length * transform.forward);

            if (Physics.Raycast(ray, out raycastHit, length))
            {
                endPosition = raycastHit.point;
            }

            //laserLine.SetPosition(0, transform.position);
            //laserLine.SetPosition(1, endPosition);

            //laserLine.enabled = true;
           // Debug.DrawRay(transform.position, endPosition, Color.red);
            Debug.Log("drawing ray");
            Debug.Log(transform.position);
            Debug.Log(transform.name);
        }
        else
        {
            //laserLine.enabled = false;
        }
	}
}

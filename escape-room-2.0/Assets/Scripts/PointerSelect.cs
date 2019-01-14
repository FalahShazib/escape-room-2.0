using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerSelect : MonoBehaviour {

    public LineRenderer laserLine;
    public float laserWidth = 0.1f;
    public float length = 10f;

    private Vector3 start;
    private Vector3 end;
	// Use this for initialization
	void Start () {

        Vector3[] initLaserPositions = new Vector3[ 2 ] {  Vector3.zero, Vector3.zero};
        laserLine.SetPositions(initLaserPositions);
        laserLine.SetWidth(laserWidth, laserWidth);
        start = transform.position;
        end = transform.forward * length;
		
	}

	// Update is called once per frame
	void Update () {

        start = transform.position;
        end = transform.forward;

        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        {
            Ray ray = new Ray(start, end);
            RaycastHit raycastHit;
            Vector3 endPosition = start + (length * end);

            if (Physics.Raycast(ray, out raycastHit, length))
            {
                endPosition = raycastHit.point;
            }

            laserLine.SetPosition(0, start);
            laserLine.SetPosition(1, endPosition);

            laserLine.enabled = true;
           //Debug.DrawRay(transform.position, endPosition, Color.red);
            Debug.Log("drawing ray");
            Debug.Log(start);
            Debug.Log(endPosition);
            Debug.Log(transform.name);
        }
        else
        {
            laserLine.enabled = false;
        }
	}
}

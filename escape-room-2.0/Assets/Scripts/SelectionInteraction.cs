using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionInteraction : MonoBehaviour {

    protected Material oldHoverMat;
    public Material yellowMat;
    public Material whiteMat;
    public Material blueMat;
    public GameObject kitchenDoor;
    public NumPadLock lockLogic;

    public GameObject light1;
    public GameObject light2;
    public GameObject light3;
    public GameObject xsign;
    private bool lights = true;

    public void OnHoverEnter(Transform t)
    {
        if (OVRInput.Get(OVRInput.RawButton.B))
        { 
            if (t.gameObject.name == "KitchenButton" || t.gameObject.name == "Cube (1)")
            {
                oldHoverMat = t.gameObject.GetComponent<Renderer>().material;
                t.gameObject.GetComponent<Renderer>().material = yellowMat;
            }
            else if (t.gameObject.name == "two-pad" || t.gameObject.name == "three-pad" || t.gameObject.name == "one-pad"
                || t.gameObject.name == "four-pad" || t.gameObject.name == "five-pad" || t.gameObject.name == "six-pad"
                || t.gameObject.name == "seven-pad" || t.gameObject.name == "eight-pad" || t.gameObject.name == "nine-pad"
                || t.gameObject.name == "zero-pad")
            {
                oldHoverMat = t.Find("Text").gameObject.GetComponent<Renderer>().material;
                t.Find("Text").gameObject.GetComponent<Renderer>().material = whiteMat;
            }
            else if (t.gameObject.name == "switch")
            {
                oldHoverMat = t.gameObject.GetComponent<Renderer>().material;
                t.Find("Cube.001").gameObject.GetComponent<Renderer>().material = yellowMat;
            }
        }
    }

    public void OnHoverExit(Transform t)
    {
        if (OVRInput.Get(OVRInput.RawButton.B))
        {
            if (t.gameObject.name == "KitchenButton" || t.gameObject.name == "Cube (1)")
            {
                t.gameObject.GetComponent<Renderer>().material = oldHoverMat;
            }
            else if (t.gameObject.name == "two-pad" || t.gameObject.name == "three-pad" || t.gameObject.name == "one-pad"
                || t.gameObject.name == "four-pad" || t.gameObject.name == "five-pad" || t.gameObject.name == "six-pad"
                || t.gameObject.name == "seven-pad" || t.gameObject.name == "eight-pad" || t.gameObject.name == "nine-pad"
                || t.gameObject.name == "zero-pad")
            {
                t.Find("Text").gameObject.GetComponent<Renderer>().material = oldHoverMat;
            }
            else if (t.gameObject.name == "switch")
            {
                t.Find("Cube.001").gameObject.GetComponent<Renderer>().material = oldHoverMat;
            }
        }
    }

    public void OnSelected(Transform t)
    {
        if (OVRInput.Get(OVRInput.RawButton.B))
        {
            if (t.gameObject.name == "KitchenButton" || t.gameObject.name == "Cube (1)")
            {
                kitchenDoor.SetActive(false);
                t.gameObject.SetActive(false);
            }

            else if (t.gameObject.name == "two-pad" || t.gameObject.name == "three-pad" || t.gameObject.name == "one-pad"
                || t.gameObject.name == "four-pad" || t.gameObject.name == "five-pad" || t.gameObject.name == "six-pad"
                || t.gameObject.name == "seven-pad" || t.gameObject.name == "eight-pad" || t.gameObject.name == "nine-pad"
                || t.gameObject.name == "zero-pad")
            {
                if (t.parent.gameObject.name == "DoorPad")
                {
                    lockLogic.doorNumPressed(t.gameObject.name);
                }
                else if (t.parent.gameObject.name == "DeskPad")
                {
                    lockLogic.deskNumPressed(t.gameObject.name);
                }
                else if (t.parent.gameObject.name == "ChestPad")
                {
                    lockLogic.chestNumPressed(t.gameObject.name);
                }
            }
            else if (t.gameObject.name == "switch")
            {
                if (lights)
                {
                    light1.transform.Find("Point Light").gameObject.SetActive(false);
                    light2.transform.Find("Point Light").gameObject.SetActive(false);
                    light3.transform.Find("Point Light").gameObject.SetActive(false);
                    xsign.SetActive(true);
                }
                else
                {
                    light1.transform.Find("Point Light").gameObject.SetActive(true);
                    light2.transform.Find("Point Light").gameObject.SetActive(true);
                    light3.transform.Find("Point Light").gameObject.SetActive(true);
                    xsign.SetActive(false);
                }
                lights = !lights; 
            }

        }
        
    }
}

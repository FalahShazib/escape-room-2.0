using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumPadLock : MonoBehaviour {

    public int[] doorCode;
    public int[] deskCode;
    public int[] chestCode;
    public GameObject bedroomDoor;
    public GameObject doorPad;
    public GameObject deskNumPad;
    public GameObject chestTop;
    int doorCounter;
    int deskCounter;
    int chestCounter;

	// Use this for initialization
	void Start ()
    {
        doorCounter = 0;
        deskCounter = 0;
        chestCounter = 0;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (doorCounter >= 4)
        {
            bedroomDoor.SetActive(false);
            doorPad.SetActive(false);
            doorCounter = 0;
            Debug.Log("door opened");
        }
        if (deskCounter >=4)
        {
            deskNumPad.SetActive(false);
            deskCounter = 0;
        }
        if (chestCounter >= 4)
        {
            chestTop.SetActive(false);
            chestCounter = 0;
        }
		
	}

    private int processName(string name)
    {
        if (name == "one-pad")
        {
            return 1;
        }
        else if (name == "two-pad")
        {
            return 2;
        }
        else if (name == "three-pad")
        {
            return 3;
        }
        else if (name == "four-pad")
        {
            return 4;
        }
        else if (name == "five-pad")
        {
            return 5;
        }
        else if (name == "six-pad")
        {
            return 6;
        }
        else if (name == "seven-pad")
        {
            return 7;
        }
        else if (name == "eight-pad")
        {
            return 8;
        }
        else if (name == "nine-pad")
        {
            return 9;
        }
        else if (name == "zero-pad")
        {
            return 0;
        }
        else return -1;
    }

    public void doorNumPressed(string name)
    {
        int num = processName(name);
        if (doorCode[doorCounter] == num)
        {
            doorCounter++;
        }
        else
        {
            doorCounter = 0;
        }
        Debug.Log(num);
        Debug.Log(doorCounter);
    }

    public void deskNumPressed(string name)
    {
        int num = processName(name);
        if (deskCode[deskCounter] == num)
        {
            deskCounter++;
        }
        else
        {
            deskCounter = 0;
        }
    }

    public void chestNumPressed(string name)
    {
        int num = processName(name);
        if (chestCode[chestCounter] == num)
        {
            chestCounter++;
        }
        else
        {
            chestCounter = 0;
        }
    }
}

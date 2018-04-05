using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Input_Controller : MonoBehaviour {
    public GameObject Left_Bat;
    public GameObject Right_Bat;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Bat goes up
if(Input.GetKey (KeyCode.W))
        {
            Debug.Log("Pressing W");
        }

//Bat Goes down
else if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Pressing S");
        }

    }
}

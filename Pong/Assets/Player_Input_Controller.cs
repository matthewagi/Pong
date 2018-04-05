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


        //Left Bat


        // keeps from having other movements at the same time
        Left_Bat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
        //Bat goes up
        if (Input.GetKey (KeyCode.W))
        {
            Debug.Log("Pressing W");
            Left_Bat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 4f, 0f);
        }

//Bat Goes down
else if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Pressing S");
            Left_Bat.GetComponent<Rigidbody>().velocity = new Vector3(0f, -4f, 0f);
        }



        //Right Bat


        Right_Bat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
        //Bat goes up
        if (Input.GetKey(KeyCode.UpArrow))
        {
         
            Right_Bat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 4f, 0f);
        }

        //Bat Goes down
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            
            Right_Bat.GetComponent<Rigidbody>().velocity = new Vector3(0f, -4f, 0f);
        }



    }
}

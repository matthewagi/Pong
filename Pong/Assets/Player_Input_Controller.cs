using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Input_Controller : MonoBehaviour {
    public GameObject target; //the enemy's target
    public float moveSpeed = 5; //move speed
    public GameObject Left_Bat;
    public GameObject Right_Bat;
    // Use this for initialization
    void Start () {
        target = GameObject.FindGameObjectWithTag("ball");
    }
	
	// Update is called once per frame
	void Update () {

        Vector3 targetDir = target.transform.position - transform.position;
        float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, q, 180);
        transform.Translate(Vector3.up * Time.deltaTime * moveSpeed);
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

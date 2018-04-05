using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Controller : MonoBehaviour {
    //rigidbody reference
    Rigidbody rb;
	// Use this for initialization
	void Start () {
        //The ball will go to a random direction
        rb = GetComponent<Rigidbody>();
        
        //randomisation for ball start
        int xDirection = Random.Range(0, 2);
        int yDirection = Random.Range(0, 2);

        Vector3 launchDirection = new Vector3 ();
        


        if (xDirection == 0)
        {
            launchDirection.x = -8f;
        }
        if (xDirection == 1)
        {
            launchDirection.x = 8f;
        }

        if (yDirection == 0)
        {
            launchDirection.y = -8f;
        }
        if (yDirection == 1)
        {
            launchDirection.y = 8f;
        }
        rb.velocity = launchDirection;

    }

    // Update is called once per frame
    void Update () {
		
	}
}

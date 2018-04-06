using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIcontroller : MonoBehaviour
{

    Rigidbody rb;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }
    void OnCollisionEnter(Collision hit)
    {


        if (hit.gameObject.name == "ball")

        {
            Debug.Log("AI");
            StartCoroutine(WaitAndFollow());
        }
    }

    IEnumerator WaitAndFollow() 
    {
        yield return new WaitForSeconds(2.2f);
        // Execute code for following ball's position
        StartCoroutine(WaitAndFollow());
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Ball_Controller : MonoBehaviour
{
   private int p2currentScore;
    public Text p2scoreText;
    private int p1currentScore;
    public Text p1scoreText;
    //rigidbody reference
    Rigidbody rb;

    // Use this for initialization
    void Start()
    {

        p2currentScore = 0;
        p1currentScore = 0;
        
        StartCoroutine(Pause());

        




    //The ball will go to a random direction
    rb = GetComponent<Rigidbody>();

       

    }


   

    



    // Update is called once per frame
    void Update()
    {

        p1scoreText.text = "" + p1currentScore;
        p2scoreText.text = "" + p2currentScore;



        if (transform.position.x < -25f) {
            
        }
        if (transform.position.x > 25f)
        {

        }

       
    }

   

    void LaunchBall ()
    {
        transform.position = Vector3.zero;
        //randomisation for ball start
        int xDirection = Random.Range(0, 2);
        int yDirection = Random.Range(0, 2);

        Vector3 launchDirection = new Vector3();



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
    IEnumerator Pause ()
    {
        
        yield return new WaitForSeconds(2.5f);
        LaunchBall();

    }
    // Reset game
    void OnTriggerEnter(Collider score)
    {
        if (score.gameObject.tag == "p2score")
        {
            p2currentScore++;
            StartCoroutine(Pause());
            Debug.Log("SCORED!");
        }   

        if (score.gameObject.tag == "p1score")
        {
            p1currentScore++;
            StartCoroutine(Pause());
            Debug.Log("SCORED!");
        }

        if(p1currentScore == 10)
        {
            Debug.Log("p1Wins");
        }

        if (p2currentScore == 10)
        {
            Debug.Log("p1Wins");
        }


    }


   



        void OnCollisionEnter(Collision hit)
    {


        if (hit.gameObject.name == "topbound")
        {
            float SpeedInXDirection = 0f;


            if (rb.velocity.x > 0f)
                SpeedInXDirection = 8f;
            if (rb.velocity.x < 0f)
                SpeedInXDirection = -8f;

            Debug.Log("Hit Top");
            rb.velocity = new Vector3(SpeedInXDirection, -8f, 0f);
        }


        
            if (hit.gameObject.name == "bottombound")
        {
            float SpeedInXDirection = 0f;


            if (rb.velocity.x > 0f)
                SpeedInXDirection = 8f;
            if (rb.velocity.x < 0f)
                SpeedInXDirection = -8f;

            Debug.Log("Hit Bottom");
            rb.velocity = new Vector3(SpeedInXDirection, 8f, 0f);
        }

        // Directions on collision with bat determined by the width of bat
        if (hit.gameObject.name == "Left_Bat")

            
        rb.velocity = new Vector3(13f, 0f, 0f);
       
            if (transform.position.y - hit.gameObject.transform.position.y < -1)
            {
                rb.velocity = new Vector3(8f, -8f, 0f);
            }

            if (transform.position.y - hit.gameObject.transform.position.y > 1)
            {
                rb.velocity = new Vector3(8f, 8f, 0f);
            }





        

        if (hit.gameObject.name == "Right_Bat")
        {
            rb.velocity = new Vector3(-13f, 0f, 0f);
            
                if (transform.position.y - hit.gameObject.transform.position.y < -1)
                {
                    rb.velocity = new Vector3(-8f, -8f, 0f);
                }

                if (transform.position.y - hit.gameObject.transform.position.y > 1)
                {
                    rb.velocity = new Vector3(-8f, 8f, 0f);
                }


            if (transform.childCount > 0)
            {
                Debug.Log("AIhit");
           
            }
            }

        }

    }

        
    



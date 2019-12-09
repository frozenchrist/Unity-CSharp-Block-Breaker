using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Ball : MonoBehaviour
{

    [SerializeField] AudioClip wallImpact;

    [SerializeField] AudioClip paddleImpact;

    [SerializeField] AudioClip loseImpact;

    [SerializeField] Paddle paddle1;

    Vector2 paddleToBallVector;

    bool hasStarted = false;


    // Start is called before the first frame update
    void Start()
    {

        paddleToBallVector = transform.position - paddle1.transform.position;

        

    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted) {

            lockBallToPaddle();

            launchBallOnMouseClick();

           

        }

        

        

    }

    private void launchBallOnMouseClick()
    {


        if (Input.GetMouseButtonDown(0)) {

            launchBallToLeft();

            GetComponent<AudioSource>().PlayOneShot(paddleImpact);

            hasStarted = true;
        } else if (Input.GetMouseButtonDown(1)) {

            launchBallToRight();

            GetComponent<AudioSource>().PlayOneShot(paddleImpact);

            hasStarted = true;

        } else if (Input.GetKeyDown("space")) {

            launchBallToStraight();

            GetComponent<AudioSource>().PlayOneShot(paddleImpact);

            hasStarted = true;

        }

       


    }

    private void launchBallToStraight()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 15f);
    }

    private void launchBallToRight()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(10f, 15f);
    }

    private void launchBallToLeft()
    {

        GetComponent<Rigidbody2D>().velocity = new Vector2 (-10f, 15f);

    }




    private void lockBallToPaddle() {

        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);

        transform.position = paddlePos + paddleToBallVector;

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (hasStarted)
        {

            GetComponent<AudioSource>().Play();

            if (collision.collider.name == "Right Collider" || collision.collider.name == "Left Collider" ||
                collision.collider.name == "Top Collider")
            {

                GetComponent<AudioSource>().PlayOneShot(wallImpact);

            }
            else if (collision.collider.name == "paddle")
            {

                GetComponent<AudioSource>().PlayOneShot(paddleImpact);


            } 
            else
            {


                GetComponent<AudioSource>().Play();


            }

            Debug.Log(collision.collider.name);


        }

    }

}

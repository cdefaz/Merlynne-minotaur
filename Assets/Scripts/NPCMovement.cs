using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{

    public float moveSpeed; 
    private Rigidbody2D MyRigidbody;
    public bool isWalking;
 

    public float walkTime;
    private float walkCounter;

    public float waitTime;
    private float waitCounter;

    private int walkDirection;

    public static Animator anim;
    public bool canMove;

   // private AddToGoogle Google;

    void Start()
    {
        MyRigidbody = GetComponent<Rigidbody2D>();
        
        anim = GetComponent<Animator>(); //anim = new GetComponent<Animator>();

        //    Google = GetComponent<AddToGoogle>();

        waitCounter = waitTime;
        walkCounter = walkTime;

        ChooseDirection();

        canMove = true;
    }


    void Update()
    {
      //  Google = GetComponent<AddToGoogle>();

        if (!canMove) //need to add that the submit button is pressed too google.flame == 1
        { MyRigidbody.velocity = Vector2.zero; // add a case statement where it is grabbing different animators by object name based on the tags (Query1/NPC1)  
            //if (Google.flame == 1)
            {
               // anim.SetTrigger("Ghost1Attack"); //never change this
              //  Google.flame = 0;
                return;
            }
        
        
        }
        if (isWalking)
        {

            walkCounter -= Time.deltaTime;

            
            switch(walkDirection)
            {
                case 0:
                    MyRigidbody.velocity = new Vector2(0, moveSpeed);
                    anim.SetFloat("Move1Y", moveSpeed);
                    break;

                case 1:
                    MyRigidbody.velocity = new Vector2(moveSpeed, 0);
                    anim.SetFloat("Move1X", moveSpeed);
                    break;

                case 2:
                    MyRigidbody.velocity = new Vector2(0, -moveSpeed);
                    anim.SetFloat("Move1Y", -moveSpeed);
                    break;

                case 3:
                    MyRigidbody.velocity = new Vector2(-moveSpeed, 0);
                    anim.SetFloat("Move1X", -moveSpeed);
                    break;
            }
            if (walkCounter < 0)
            {
                isWalking = false;

                waitCounter = waitTime;
            }
        }
        else
        {
            waitCounter -= Time.deltaTime;
            MyRigidbody.velocity = Vector2.zero;
            if (waitCounter < 0)
            {
                ChooseDirection();
            }
        }


    }

    public void ChooseDirection()
    {
        walkDirection = Random.Range(0, 4);
        isWalking = true;
        walkCounter = walkTime;
    }
}

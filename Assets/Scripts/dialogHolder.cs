using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dialogHolder : MonoBehaviour {

    public string dialogue;
    private DialogueManager dMAn;
    private bool dialogueA;
    public GameObject NPCimg;

    // Use this for initialization
    void Start () {
        dMAn = FindObjectOfType<DialogueManager>();

        //dialogue = "test";
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            NPCimg.gameObject.SetActive(false);
        }

        dialogueA = dMAn.dialogActive;
        if (dialogueA == false)
        {
            NPCimg.gameObject.SetActive(false);
        }
    }
  void OnTriggerStay2D(Collider2D other)
    {
        NewMethod(other);
    }

    private void NewMethod(Collider2D other)
    {

        

        if (other.gameObject.name == "Player") //this is attached to the monster
        {
            dialogueA = dMAn.dialogActive;
            if (dialogueA == false && Input.GetKeyUp(KeyCode.RightControl))
            {
                dMAn.ShowBox(dialogue);
                NPCMovement.anim = transform.parent.GetComponent<Animator>();

                //here is where I would make an image appear.
                NPCimg.gameObject.SetActive (true);

                //tab = go to field
                if (Input.GetKeyUp(KeyCode.Return))
                {
                    GetComponent<AddToGoogle>().Send();
                    Debug.Log("Enter was pressed");
                    
                }


                    if (transform.parent.GetComponent<NPCMovement>() != null)
                {
                    transform.parent.GetComponent<NPCMovement>().canMove = false;
                }
                    }
            }
        }
    }




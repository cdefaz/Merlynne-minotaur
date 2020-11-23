using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    public static dialogHolder dHol;

    public GameObject dBox;
    public Text dText;

    public bool dialogActive;


	// Use this for initialization
	void Start () {
        if (dHol == null) dHol = dBox.AddComponent<dialogHolder>();

    }
	
	// Update is called once per frame
	void Update () {
        if (dialogActive && Input.GetKeyDown(KeyCode.LeftControl))
        { dBox.SetActive(false);
            dialogActive = false;
            Debug.Log("Dialogue was closed without response.");
        }

    }
    public void ShowBox(string dialogue)
    {
        dialogActive = true;
        dBox.SetActive(true);
        dText.text = dialogue;
        dHol.dialogue = dText.text;

        //do I want to set anim here?
    }
}

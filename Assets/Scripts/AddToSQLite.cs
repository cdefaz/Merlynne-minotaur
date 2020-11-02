using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddToSQLite : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject username;
    public GameObject email;
    public GameObject phone;
    public GameObject playerid;

    private string Name;
    private string Email;
    private string Phone;
    public string PlayerId;
   // private string PlayerId2;
    private string Dialogue;
    private string levelId;
    public int expToGive;
    private PlayerStats thePlayerStats;
    private DialogueManager theDM;
    private dialogHolder dHol;
    private SceneManager2 scMan;

    public bool flame;
    void Start()
    {
        
        thePlayerStats = FindObjectOfType<PlayerStats>();
        theDM = FindObjectOfType<DialogueManager>();
        dHol = FindObjectOfType<dialogHolder>();
        scMan = FindObjectOfType<SceneManager2>();

        flame = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (theDM?.dialogActive == true && Input.GetKeyUp(KeyCode.Return))
        {
            Send();
           // dHol.NPCimg.gameObject.SetActive(false);
            Debug.Log("Enter was pressed");
        }
        
    }

    IEnumerator Post(string name, string email, string phone, string playerid, string dialog, string lvlid)
    {
        LevelDb mlevelDb = new LevelDb();
        mlevelDb.addData(new DataEntity(playerid, name, email, phone, lvlid, dialog));
        mlevelDb.close();
        yield return mlevelDb;
        
        //PlayerId = playerid.GetComponent<InputField>().text;
    }

    public void Send()
    {
        Name = username.GetComponent<InputField>().text;
        Email = email.GetComponent<InputField>().text;
        Phone = phone.GetComponent<InputField>().text;
        PlayerId = playerid.GetComponent<InputField>().text;
        Dialogue = DialogueManager.dHol.dialogue;
        levelId = "M_Minotaur"; //testing //scMan.pLevel; 

        // DialogueManager.dHol.NPCimg.SetActive(false); //help
        NPCMovement.anim.SetTrigger("Ghost1Attack"); //Jim added this 
        //flame = false; //prereq for animation

        StartCoroutine(Post(Name, Email, Phone, PlayerId, Dialogue, levelId));
        username.GetComponent<InputField>().text = "";
        email.GetComponent<InputField>().text = "";
        phone.GetComponent<InputField>().text = "";
        thePlayerStats.AddExperience(expToGive);

        //flame = true; //cancel for animation...we can set this in the other script.
       // dHol.NPCimg.SetActive(false);
        theDM.dBox.SetActive(false);
        theDM.dialogActive = false;
        //this is where I would turn off the image
    }

    public void SaveID()
    {
        PlayerId = playerid.GetComponent<InputField>().text;
        PlayerPrefs.SetString("playerID", PlayerId);
    }

    public void LoadID()
    {
        PlayerId = PlayerPrefs.GetString("playerID");
        playerid.GetComponent<InputField>().text = PlayerId;
    }

    public void Begin()
    {
        Name = "START";
        Email = "START";
        Phone = "START";
        PlayerId = playerid.GetComponent<InputField>().text; 
        Dialogue = "START";
        levelId = "M_Minotaur";
        StartCoroutine(Post(Name, Email, Phone, PlayerId, Dialogue, levelId));
        username.GetComponent<InputField>().text = "";
        email.GetComponent<InputField>().text = "";
        phone.GetComponent<InputField>().text = "";


        theDM.dBox.SetActive(false);
        theDM.dialogActive = false;
    }

     public void Nextlvl()
    {
        Name = "NEXT";
        Email = "NEXT";
        Phone = "NEXT";
        PlayerId = playerid.GetComponent<InputField>().text; //doesn't work because not in the same canvas/scene
        Dialogue = "NEXT";
        levelId = "M_Minotaur";
        StartCoroutine(Post(Name, Email, Phone, PlayerId, Dialogue, levelId));
        username.GetComponent<InputField>().text = "";
        email.GetComponent<InputField>().text = "";
        phone.GetComponent<InputField>().text = "";


        theDM.dBox.SetActive(false);
        theDM.dialogActive = false;

    }

    public void StopGame()
    {
        Name = "END";
        Email = "END";
        Phone = "END";
        PlayerId = playerid.GetComponent<InputField>().text;
        Dialogue = "END";
        levelId = "M_Minotaur";
        StartCoroutine(Post(Name, Email, Phone, PlayerId, Dialogue, levelId));
        username.GetComponent<InputField>().text = "";
        email.GetComponent<InputField>().text = "";
        phone.GetComponent<InputField>().text = "";


        theDM.dBox.SetActive(false);
        theDM.dialogActive = false;
    }
}

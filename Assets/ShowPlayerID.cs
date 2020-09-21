using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPlayerID : MonoBehaviour
{

    private AddToGoogle AddGoog;
    public Text IDText;

    // Use this for initialization
    void Start()
    {
        AddGoog = GetComponent<AddToGoogle>();
    }

    // Update is called once per frame
    void Update()
    {
        IDText.text = "ID: " + AddGoog.playerid;
    }
}

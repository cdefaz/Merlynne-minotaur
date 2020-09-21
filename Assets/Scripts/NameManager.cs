using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameManager : MonoBehaviour {

    private AddToGoogle aGoog;
    public Text nameText;

    // Use this for initialization
    void Start () {
        aGoog = GetComponent<AddToGoogle>();
    }
	
	// Update is called once per frame
	void Update () {
        nameText.text = aGoog.PlayerId;
    }
}

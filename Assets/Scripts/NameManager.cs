using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameManager : MonoBehaviour {

    private AddToSQLite aSQL;
    public Text nameText;

    // Use this for initialization
    void Start () {
        aSQL = GetComponent<AddToSQLite>();
    }
	
	// Update is called once per frame
	void Update () {
        nameText.text = aSQL.PlayerId;
    }
}

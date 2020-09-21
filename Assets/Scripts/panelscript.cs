using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class panelscript : MonoBehaviour {

    public GameObject Panel;
    int counter;

    public void showhidePanel()
    {
        counter++;
        if (counter % 2 == 1) {
            Panel.gameObject.SetActive (false);
        } else {
            Panel.gameObject.SetActive (true);
        }
     }
}
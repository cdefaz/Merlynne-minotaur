using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

    private PlayerStats thePS;
    public Text levelText;
    Scene m_Scene;

    //private SceneManager2 scan2;

    // Use this for initialization
    void Start () {
        thePS = GetComponent<PlayerStats>();
        // scan2 = GetComponent<SceneManager2>();
        m_Scene = SceneManager.GetActiveScene();
    }
	
	// Update is called once per frame
	void Update () {
        m_Scene = SceneManager.GetActiveScene();
        levelText.text = "Hits Landed: " + thePS.currentExp + " / " + thePS.toLevelUp[m_Scene.buildIndex] + " | Progress: " + thePS.currentLevel + " / 22 "; //scene number *2 works too //thePS.toLevelUp[thePS.currentLevel] //thePS.toLevelUp[m_Scene.buildIndex]
    }
}

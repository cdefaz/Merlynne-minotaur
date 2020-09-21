using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour {

    public int currentLevel;

    public int currentExp;

    public int[] toLevelUp;

    Scene m_Scene;

    // Use this for initialization
    void Start () {
        m_Scene = SceneManager.GetActiveScene();
    }
	
	// Update is called once per frame
	void Update () {
		if(currentExp >= toLevelUp[currentLevel])
        {
            currentLevel++;
        }
	}

    public void AddExperience(int experienceToAdd)
    {m_Scene = SceneManager.GetActiveScene();
        if (currentExp + experienceToAdd < toLevelUp[m_Scene.buildIndex])           //if (currentExp != toLevelUp[currentLevel])  is the previous one. thePS.toLevelUp[m_Scene.buildIndex]
        {
            currentExp += experienceToAdd; // plus the 1 pt per monster
        }
        else
        { currentExp = toLevelUp[m_Scene.buildIndex]; } // if it exceeds the exp needed to lvl up for that lvl, then cap it off
    }
}

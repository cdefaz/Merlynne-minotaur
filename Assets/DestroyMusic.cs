using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyMusic : MonoBehaviour {

    Scene m_Scene;
    public GameObject bgmusic;

    // Use this for initialization
    void Start () {
        m_Scene = SceneManager.GetActiveScene();

    }
	
	// Update is called once per frame
	void Update () {
        m_Scene = SceneManager.GetActiveScene();
        if (m_Scene.buildIndex == 1 )
            {
            Destroy(bgmusic, 0);
        }
        

    }
}

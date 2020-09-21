using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Resetter : MonoBehaviour
{
    Vector3 originalPos;
    // public GameObject avatar;
    Scene m_Scene;
    Scene f_Scene;
    // private PlayerController PlayCon;

    // Use this for initialization
    void Start()
    {
        m_Scene = SceneManager.GetActiveScene();
        //    PlayCon = FindObjectOfType<PlayerController>();
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        m_Scene = SceneManager.GetActiveScene();
        if (m_Scene.buildIndex != f_Scene.buildIndex)
        {
            transform.position = originalPos;
            //enabled = false;
            //Destroy(bgmusic, 0);
        }
        f_Scene = SceneManager.GetActiveScene();
    }
}
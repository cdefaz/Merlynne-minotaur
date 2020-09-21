using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManager2 : MonoBehaviour
{
    public GameObject sBut;
    public int pLevel;
    private PlayerStats PStat;


    // Use this for initialization
    void Start()
    {
        PStat = FindObjectOfType<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pLevel <= PStat.currentLevel)
        {
            sBut.SetActive(true);
        }

    }
}
using UnityEngine;
using System.Collections;

public class doNotDestroy : MonoBehaviour
{ 
    public float health;
    public float experience;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
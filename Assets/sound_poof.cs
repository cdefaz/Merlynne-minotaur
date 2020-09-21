using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound_poof : MonoBehaviour {

    public void OnClick(AudioSource poof)
    {
        poof.Play();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {
    public static AudioClip attackSound, letGoSound;
    static AudioSource audioSrc;
	// Use this for initialization
	void Start () {
        attackSound = Resources.Load<AudioClip>("magical_disapearance");
        letGoSound = Resources.Load<AudioClip>("magical_poof");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update() {
    }
    public static void PlaySound (string clip)
        {
          switch (clip)
            {
                case "magical_disapearance":
                    audioSrc.PlayOneShot(attackSound);
                    break;
                case "magical_poof":
                    audioSrc.PlayOneShot(letGoSound);
                    break;

            }

        }
		
	}


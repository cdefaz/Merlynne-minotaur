using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class AudioPlay : MonoBehaviour
{
    void OnEnable()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        audio.PlayDelayed(44100);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TriggerSound : MonoBehaviour
{
    //public GameObject triggerObject;
    public AudioSource audioSource;
    public AudioClip audioClip;

    /*public void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        audioSource.Play();
    }*/

    private void OnTriggerEnter(Collider other)
    {
        audioSource.PlayOneShot(audioClip);
    }

    private void OnTriggerExit(Collider other)
    {
        audioSource.Stop();
    }
}

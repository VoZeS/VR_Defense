using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBell : MonoBehaviour
{

    public AudioClip bell;



    private void OnTriggerEnter(Collider other)
    {
       
        

        if (other.gameObject.tag == "Rope")
        {
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.PlayOneShot(bell);
        }
    }
}

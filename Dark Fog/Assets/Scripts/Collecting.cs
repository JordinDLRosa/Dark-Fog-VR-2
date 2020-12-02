using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collecting : MonoBehaviour
{
    public AudioSource collectSound;
    
    /*void Start()
    {
        gameObject.tag = "Player";
    }
    */
    void OnTriggerEnter(Collider other)
    {
            collectSound.Play();
            
    }
    void OnTriggerExit(Collider other)
    {
        Object.Destroy(gameObject, 1.0f);
        ScoringSystem.theScore += 1;

    }
}

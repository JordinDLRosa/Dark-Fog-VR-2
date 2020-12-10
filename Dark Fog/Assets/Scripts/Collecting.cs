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
        ScoringSystem.theScore += 1;
        Debug.Log(gameObject + "Objects Destoryed");


    }
    void OnTriggerExit(Collider other)
    {
        Object.Destroy(gameObject, 0.5f);
        
    }
}

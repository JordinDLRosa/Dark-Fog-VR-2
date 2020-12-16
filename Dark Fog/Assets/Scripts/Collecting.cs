using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
public class Collecting : MonoBehaviour
{
    public AudioSource collectSound;

    public GameObject monster;
    public static int mSpeed = 15;

    void Start()
    {
        monster.GetComponent<NavMeshAgent>().speed = mSpeed;
    }
    
    void Update()
    {
        if (ScoringSystem.theScore == 2)
        {
            monster.GetComponent<NavMeshAgent>().speed = mSpeed + 5;
        }
        else if (ScoringSystem.theScore == 3)
        {
            monster.GetComponent<NavMeshAgent>().speed = mSpeed + 5;
        }
        else if (ScoringSystem.theScore == 4)
        {
            monster.GetComponent<NavMeshAgent>().speed = mSpeed + 5;
        }
        else if (ScoringSystem.theScore == 5)
        {
            monster.GetComponent<NavMeshAgent>().speed = mSpeed + 5;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();

            Debug.Log(gameObject + "Collision detected");
            ScoringSystem.theScore += 1;
        Destroy(gameObject);
        //Object.Destroy(gameObject, 0.5f);
    }
    //void OnTriggerExit(Collider other)
    //{
        

    //}
}

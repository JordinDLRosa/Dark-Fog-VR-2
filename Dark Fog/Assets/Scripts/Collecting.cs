using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
        ScoringSystem.theScore += 1;
       
        Debug.Log(gameObject + "Objects Destoryed");
        

    }
    void OnTriggerExit(Collider other)
    {

        Object.Destroy(gameObject, 2f);

    }
}

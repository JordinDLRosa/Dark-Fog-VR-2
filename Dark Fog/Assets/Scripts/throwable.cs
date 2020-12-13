using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class throwable : MonoBehaviour
{

    public GameObject monster;
    private static int speed;
    // Start is called before the first frame update
    /*void Update()
    {
        speed = Collecting.mSpeed;
    }*/
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "monster")
        {
            monster.GetComponent<NavMeshAgent>().speed = 0;
            Object.Destroy(gameObject, 2.0f);
        }

    }

    void OnTriggerExit(Collider other)
    {
        monster.GetComponent<NavMeshAgent>().speed = Collecting.mSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

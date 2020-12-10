using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class throwable : MonoBehaviour
{

    public GameObject monster;
    
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "monster")
        {
            monster.GetComponent<NavMeshAgent>().speed = 0;
            Object.Destroy(gameObject, 1.0f);
        }

    }

  
    // Update is called once per frame
    void Update()
    {
        
    }
}

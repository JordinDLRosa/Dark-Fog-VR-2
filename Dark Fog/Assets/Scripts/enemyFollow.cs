using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class enemyFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public NavMeshAgent enemy;
    public Transform Player;
    private int health = 100;
    public Text healthText;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            health = health - 25;
        }

        if (health <= 0)
        {
            SceneManager.LoadScene(4);
        }

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health : " + health;

        enemy.SetDestination(Player.position);
    }
}

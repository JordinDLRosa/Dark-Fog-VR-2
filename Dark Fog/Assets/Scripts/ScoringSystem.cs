using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Permissions;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public static int theScore;

    public GameObject monster;
    public GameObject doorToHeaven;

    void Update()
    {
        scoreText.GetComponent<Text>().text = "Faith: " + theScore;
        if(theScore >= 1)
        {
            monster.SetActive(true);

        }
        if(theScore >= 5)
        {
            doorToHeaven.SetActive(true);
        }
    }
}

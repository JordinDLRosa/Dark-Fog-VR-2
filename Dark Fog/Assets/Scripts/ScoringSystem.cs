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

    void Update()
    {
        scoreText.GetComponent<Text>().text = "Pages Collected: " + theScore;
    }
}

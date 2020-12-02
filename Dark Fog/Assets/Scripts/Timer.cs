using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public int timeLeft = 180;
    public Text countdown;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("LoseTime");
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        countdown.text = ("" + timeLeft);
        if (timeLeft == 0)
        {
            GameOver();// genarally helpful by separating it
        }
    }
    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }

    public void GameOver()
    {
        Application.Quit();

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public int timeLeft = 180;
    public Text timer;
    void Start()
    {
        StartCoroutine("LoseTime");
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        timer.text = ("" + timeLeft);
        if (timeLeft == 0)
        {
            SceneManager.LoadScene(3);
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
}

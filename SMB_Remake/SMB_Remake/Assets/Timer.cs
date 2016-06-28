using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timeText;

    void Start()
    {
        timeText.text =  6.ToString();
        InvokeRepeating("ReduceTime", 1, 1);
    }

    void ReduceTime()
    {
        int currentTime = int.Parse(timeText.text) - 1;
        timeText.text = currentTime.ToString();

        if (currentTime == 0)
        {
            //audio.Play();
            Invoke("Reload", 1.59f);//waits until sound is played to reload
            Destroy(timeText);
        }
    }

    void Reload()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
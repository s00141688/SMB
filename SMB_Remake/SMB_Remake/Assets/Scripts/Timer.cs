using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public AudioClip timeUpSound;
    public Text timeText;
    //public int levelTime = 3;

    void Start()
    {
        timeText.text = 60.ToString();
        InvokeRepeating("ReduceTime", 1, 1);
    }

    void ReduceTime()
    {
        int currentTime = int.Parse(timeText.text) - 1;
        timeText.text = currentTime.ToString();

        if (currentTime == 0)
        {
            timeText.text = "TIME IS UP!!";
            AudioSource.PlayClipAtPoint(timeUpSound, new Vector3(0,0,0));
            Invoke("Reload", 1.59f);//waits until sound is played to reload
            //Destroy(timeText);
        }
    }

    void Reload()
    {
        //Application.LoadLevel(Application.loadedLevel);
        SceneManager.LoadScene(Application.loadedLevel);
    }
}
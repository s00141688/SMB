using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PickBanana : MonoBehaviour
{
    public AudioClip bananaSound;
    public Text bananaText;
    private int count;

    void Start()
    {
        count = 0;
        SetCountText();
    }
    

    void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(bananaSound, transform.position);
        //int score = int.Parse(bananaText.text) + 1;
        //bananaText.text = score.ToString();
        count = count +1;
        SetCountText();
        Destroy(gameObject);

        //GUI.Label(new Rect(0, 0, 20, 80), bananaText.ToString());
        
    }

    void SetCountText()
    {
        bananaText.text = "Bananas : " + count.ToString();
    }
}
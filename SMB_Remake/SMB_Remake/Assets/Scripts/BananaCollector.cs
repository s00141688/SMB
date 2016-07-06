using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BananaCollector : MonoBehaviour {

    private int count = 0;
    public Text bananaText;
    public AudioClip bananaSound;

    void Update()
    {
        SetCountText();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            AudioSource.PlayClipAtPoint(bananaSound, transform.position);
            other.gameObject.SetActive(false);
            count = count + 1;
        }
    }

    void SetCountText()
    {
        bananaText.text = "Bananas : " + count.ToString();
    }
}

using UnityEngine;
using System.Collections;

public class EndLevel : MonoBehaviour
{
    public GameObject complete;
    public GameObject player;
    public AudioClip finishSound;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            AudioSource.PlayClipAtPoint(finishSound, transform.position);
            Invoke("Reload", 2);
            GameObject alert = Instantiate(complete, new Vector3(0.5f, 0.5f, 0), transform.rotation) as GameObject;
            //other.gameObject.SetActive(false);
            //Destroy(player.GetComponent<Rigidbody>());
        }
    }

    void Reload()
    {
        Application.Quit();
        Application.LoadLevel(Application.loadedLevel);
    }
}
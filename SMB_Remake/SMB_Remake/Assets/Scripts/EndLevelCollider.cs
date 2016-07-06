using UnityEngine;
using System.Collections;

public class EndLevelCollider : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            other.gameObject.SetActive(false);
        }
    }
}

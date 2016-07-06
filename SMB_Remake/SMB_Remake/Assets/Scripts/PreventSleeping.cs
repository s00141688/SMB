using UnityEngine;
using System.Collections;

public class PreventSleeping : MonoBehaviour {

    public GameObject player;
    public Rigidbody rb;

    //prevents non movivg physics entering sleep mode        
	void Update () {
        if (player.tag.Contains("player"))
            rb = player.GetComponent<Rigidbody>();
        if (rb.IsSleeping())
            rb.WakeUp();
    }
}

using UnityEngine;
using System.Collections;

public class PreventSleeping : MonoBehaviour {

    public GameObject player;
    public Rigidbody rb;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (player.tag.Contains("player"))
            rb = player.GetComponent<Rigidbody>();
        if (rb.IsSleeping())
            rb.WakeUp();
    }
}

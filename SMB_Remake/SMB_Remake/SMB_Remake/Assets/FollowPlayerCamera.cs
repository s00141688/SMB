using UnityEngine;
using System.Collections;

public class FollowPlayerCamera : MonoBehaviour
{
    public GameObject player;
    private Vector3 playerOffset;

    // Use this for initialization
    void Start()
    {
        playerOffset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        player.tag = "player";
        transform.LookAt(player.transform);
        transform.position = player.transform.position + playerOffset;
    }
}

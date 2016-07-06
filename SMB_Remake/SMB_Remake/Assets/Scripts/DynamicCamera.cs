using UnityEngine;
using System.Collections;

public class DynamicCamera : MonoBehaviour
{
    public GameObject player;
    private Vector3 playerOffset;
    Vector3 lastPos;
    Vector3 viewDir;
    private float distance = 10;

    void Start()
    {
        // ensure forward direction at start
        playerOffset = transform.position - player.transform.position;
        lastPos = player.transform.position - transform.forward * distance + playerOffset;
    }

    void Update()
    {
        Vector3 ballPos = player.transform.position;
        Vector3 newDir = ballPos - lastPos;  // direction from last position
        newDir.y = 0;    // keep the camera on horizontal plane
        if (newDir.magnitude > distance)
        {  // only recalculate after min distance
            viewDir = newDir;
            lastPos = ballPos;
        }
        transform.position = ballPos;
        transform.forward = Vector3.Slerp(transform.forward, viewDir.normalized, Time.deltaTime);
    }
}

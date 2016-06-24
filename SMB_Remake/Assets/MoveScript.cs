using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour
{

    //A bool to enable or disable smooth mode.
    public bool smoothMotion = true;

    //This is how quickly we MoveTowards the input axis.
    public float smoothSpeed = 100f;

    //The maximum input axis to reach. Setting this lower will rotate the platform less, and higher will be more.
    public float multiplier = 100f;
    private float hSmooth = 0f;
    private float vSmooth = 0f;
    private float h;
    private float v;

    void Update()
    {
        //Get Vertical and Horizontal axis from Input
        h = Input.GetAxis("Horizontal") * multiplier;
        v = Input.GetAxis("Vertical") * multiplier;

    }

    void FixedUpdate()
    {
        hSmooth = Mathf.MoveTowards(hSmooth, h, smoothSpeed * Time.deltaTime);
        vSmooth = Mathf.MoveTowards(vSmooth, v, smoothSpeed * Time.deltaTime);

        //Rotate to match the new axis using EulerAngles(Must be used).
        if (!smoothMotion)
        {
            transform.rotation = Quaternion.EulerAngles(new Vector3(h, 0f, v));
        }
        else
        {
            transform.rotation = Quaternion.EulerAngles(new Vector3(hSmooth, 0f, vSmooth));
        }
    }
}
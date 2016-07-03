using UnityEngine;
using System.Collections;

public class MovingPlatforms : MonoBehaviour {

    public Transform movingPlatform;
    public Transform position1;
    public Transform position2;
    public Vector3 newPosition;

    private string currentState; //statemachine 
    public float smooth;
    public float resetTime;

	// Use this for initialization
	void Start()
    {
        ChangeTarget();
	}
	
	// Update run at consistent interval
	void FixedUpdate()
    {
        movingPlatform.position = Vector3.Lerp(movingPlatform.position, newPosition, smooth * Time.deltaTime); //move positions and speed
	}

    void ChangeTarget()
    {
        if (currentState == "Moving to platform 1")
        {
            currentState = "Movng to platform 2";
            newPosition = position2.position;
        }

        else if (currentState == "Moving to platform 2")
        {
            currentState = "Moving to platform 1";
            newPosition = position1.position;
        }

        else if (currentState == "")
        {
            currentState = "Moving to platform 2";
            newPosition = position2.position;
        }

        Invoke("ChangeTarget", resetTime);      //auto repets the method
    }
}

using UnityEngine;
using System.Collections;

public class MovingPlatforms : MonoBehaviour {

    public Transform movingPlatform;
    public Transform position1;
    public Transform position2;
    public Vector3 newPosition;
    private string currentState = ""; //stateholder
    public float smooth;
    public float resetTime;

	// Use this for initialization
	void Start()
    {
        //ChangeTarget();
        InvokeRepeating("ChangeTarget", resetTime, 2);          //should this 2 not be number of times runthrough but seems to be the wait time???
    }
	
	// Update run at consistent interval
	void FixedUpdate()
    {
        movingPlatform.position = Vector3.Lerp(movingPlatform.position, newPosition, smooth * Time.deltaTime); //move positions and speed
	}

    void ChangeTarget()
    {
        if (currentState == "")
        {
            newPosition = position2.position;
            currentState = "Moving to platform 1";
        }
        else if (currentState == "Moving to platform 1")
        {
            newPosition = position1.position;
            currentState = "Movng to platform 2";
        }
        else if (currentState == "Moving to platform 2")
        {            
            newPosition = position2.position;
            currentState = "Moving to platform 1";
        }
       
        /* Invoke("ChangeTarget", resetTime);*/      //auto repeats the method
        //InvokeRepeating("ChangeTarget", 1, 100);
    }
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MovingPlatforms : MonoBehaviour
{
    public Transform movingPlatform;
    public Transform position1;
    public Transform position2;
    public Transform targetPosition;
    public Vector3 newPosition;
    private string currentState = ""; //stateholder
    public float smooth;
    public float resetTime;

    //public enum POSITION { pos1, pos2}
    //public Dictionary<POSITION, Vector3> positionList = new Dictionary<POSITION, Vector3>();

    void Start()
    {
        SetTarget(position2);
    }

    void FixedUpdate()
    {
        //movingPlatform.position = Vector3.Lerp(movingPlatform.position, newPosition, smooth * Time.deltaTime);

        movingPlatform.position =  movingPlatform.position + newPosition * smooth * Time.fixedDeltaTime;

        if (Vector3.Distance(movingPlatform.position, targetPosition.position) < smooth * Time.fixedDeltaTime)
        {
            SetTarget(targetPosition == position1 ? position2 : position1);
        }    
    }


    //Dictionary<POSITION, Vector3> positionList = new Dictionary<POSITION, Vector3>();
    //Vector3 Position1 = position1.position;
    //Vector3 Position2 = position2.position;
    //positionList.Add(POSITION.pos1, Position1);
    //positionList.Add(POSITION.pos2, Position2);

    void SetTarget(Transform _targetPosition)
    {
        targetPosition = _targetPosition;
        newPosition = (targetPosition.position - movingPlatform.position);
    }
}

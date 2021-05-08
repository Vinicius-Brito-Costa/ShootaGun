using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotECross : MonoBehaviour
{
    public Transform youTrans;
    public Transform wayPointTrans;

    void Update()
    {
        Vector3 youDir = youTrans.forward;

        Vector3 waypointDir = wayPointTrans.position - youTrans.position;

        Vector3 crossProduct = Vector3.Cross(youDir, waypointDir);

        float dotProduct = Vector3.Dot(crossProduct, youTrans.up);

        float dotDot = Vector3.Dot(youTrans.forward, waypointDir);


        if (dotProduct > 0f)
        {
            Debug.Log("Turn right");
        }
        else
        {
            Debug.Log("Turn left");
        }
        if(dotDot > 0f)
        {
            Debug.Log("Frente");
        }
        else
        {
            Debug.Log("Tras");
        }
    }
}

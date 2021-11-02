using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint;
    LineRenderer laserLine;

    [System.Obsolete]
    void Start()
    {
        laserLine = GetComponent<LineRenderer>();
    }

 
    void Update()
    {
        laserLine.SetPosition(0, startPoint.position);
        laserLine.SetPosition(1, endPoint.position);
    }
}

 using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Vuforia;

public class ARLineDistanceCalculator : MonoBehaviour
{
     public Transform[] markerTransforms;
     public float length =0;

     LineRenderer lineRenderer;
     
     float distance = 0.0f;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = markerTransforms.Length;
    }

    void Update()
    {
       
        

        // Calculate and update the line distances between markers here.
        // You can use Vector3.Distance to calculate distances.
    }

    public void BFound()
    {
        Debug.Log("Line");
        length = 2;
        DrawLine();
    }
    public void Cfound()
    {
        length = 3;
        lineRenderer.loop = true  ;
        DrawLine();
        
        Debug.Log("Triangle");
    }

    void DrawLine()
    {
        for (int i = 0; i < length; i++)
        {
            if (markerTransforms[i] != null && markerTransforms[i])
            {
                lineRenderer.SetPosition(i, markerTransforms[i].position);

                /*if (markerTransforms.Length > 1)
                {

                    distance = Vector3.Distance(markerTransforms[length - 1].position, markerTransforms[length - 2].position);

                    // Print the distance to the console
                    Debug.Log("Distance between targets: " + distance + " centimeters");
                }*/

            }


        }
    }
}

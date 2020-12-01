using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    public Transform muzzle;
    public Transform crosshair;
    public Camera viewport;
    Ray ray;

    public float maxDistance = 100;

    void Update()
    {

        //ray = new Ray(muzzle.position, muzzle.forward);
        //RaycastHit hit;
        //if (Physics.Raycast(muzzle.position, muzzle.TransformDirection(Vector3.forward), out hit, maxDistance))
        //{
        //    crosshair.position = viewport.WorldToScreenPoint(hit.point);
        //    Debug.Log("hitTHis");
        //}
        //else
        
            crosshair.position = viewport.WorldToScreenPoint(muzzle.position+muzzle.forward * maxDistance);
        
    }

    }

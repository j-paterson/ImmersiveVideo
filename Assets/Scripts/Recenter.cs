using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class Recenter : MonoBehaviour
{
    float timer = 0;
    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetUp(OVRInput.Button.SecondaryIndexTrigger) || OVRInput.GetUp(OVRInput.Button.One))
        {
            timer = 0;
        }

        if (OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger, OVRInput.Controller.Touch) > 0.8f || OVRInput.Get(OVRInput.Button.One))
        {
            //We track how long 
            timer += Time.deltaTime;

            if (timer > 3.0)
            {
                UnityEngine.XR.InputTracking.Recenter();
                timer = 0;
            }
        }

    }

    public void Start()
    {
        timer = 0;
    }
}
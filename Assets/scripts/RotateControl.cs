using Microsoft.MixedReality.Toolkit.UI.BoundsControl;
using MRTK.Tutorials.GettingStarted;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateControl : MonoBehaviour
{
    public GameObject car;
    public bool correct;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localRotation.eulerAngles.z < 20 && transform.localRotation.eulerAngles.z > -20) { 
            RotateController();
            correct = true;
        }
    }

    public void RotateController()
    {
        correct = true;
        gameObject.transform.rotation = car.transform.rotation; 
        gameObject.GetComponent<BoundsControl>().enabled = false;
       
        
        
    }
}

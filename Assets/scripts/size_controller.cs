using Microsoft.MixedReality.Toolkit.UI.BoundsControl;
using MRTK.Tutorials.GettingStarted;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class size_controller : MonoBehaviour
{

    public GameObject roseP;
    public bool correct;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.x > 1.45 && transform.localScale.y > 1.45 && transform.localScale.z > 1.45)
        {
           
            ScaleControl();
        }
       
    }

    public void ScaleControl()
    {
         correct = true;
            gameObject.transform.localScale = new Vector3((float)1.5, (float)1.5, (float)1.5);
            gameObject.GetComponent<BoundsControl>().enabled = false;

      
    }


}

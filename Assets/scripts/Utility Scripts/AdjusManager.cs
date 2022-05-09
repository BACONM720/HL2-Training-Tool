using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjusManager : MonoBehaviour
{
    public GameObject RotateArrowRight;
    public GameObject signRight;
    public GameObject RotateArrowLeft;
    public GameObject signLeft;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(updateArrow());

    }
    //simple method to hide one arrow then show the other after a set amount of time has passed
    IEnumerator updateArrow()
    {
    //wait 10 seconds
       yield return new WaitForSecondsRealtime(10);
        //hide the first arrow
        RotateArrowRight.SetActive(false);
        //hide the arrows accompanying text
        signRight.SetActive(false);
        //show the next arrow
        RotateArrowLeft.SetActive(true);
        //show the accompanying text
        signLeft.SetActive(true);

    }
}

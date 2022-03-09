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

    IEnumerator updateArrow()
    {
       yield return new WaitForSecondsRealtime(10);
        RotateArrowRight.SetActive(false);
        signRight.SetActive(false);
        RotateArrowLeft.SetActive(true);
        signLeft.SetActive(true);

    }
}

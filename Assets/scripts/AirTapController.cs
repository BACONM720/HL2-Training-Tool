using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirTapController : MonoBehaviour
{

    public GameObject bear;
    public GameObject dog;
    public GameObject cat;


    public GameObject bearPos;
    public GameObject dogPos;
    public GameObject catPos;

    public GameObject BasketBall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(bear.transform.position == bearPos.transform.position)
        {
            bear.SetActive(false);
            bearPos.SetActive(false);
            dog.SetActive(true);
            dogPos.SetActive(true);
        }

        if (dog.transform.position == dogPos.transform.position)
        {   
            dog.SetActive(false);
            dogPos.SetActive(false);
            cat.SetActive(true);
            catPos.SetActive(true);
           
        }
        if (cat.transform.position == catPos.transform.position)
        { 
            cat.SetActive(false);
            catPos.SetActive(false);
            BasketBall.SetActive(true);

           
        }




    }
}

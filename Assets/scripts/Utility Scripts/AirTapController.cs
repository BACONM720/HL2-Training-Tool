using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirTapController : MonoBehaviour
{

    public GameObject bear;
    public GameObject dog;
    public GameObject cat;
    public GameObject Check;
    public GameObject bearPos;
    public GameObject dogPos;
    public GameObject catPos;
    public GameObject panel1;
    public GameObject nearMenu;

    public GameObject BasketBall;
    // Start is called before the first frame update
    void Start()
    {
      
    }

        // Update is called once per frame
        void FixedUpdate()
        {
        //check if the bear is in position
            if (bear.transform.position == bearPos.transform.position)
            {
            //if so then hide the bear, and its target and show the next animal
                bear.SetActive(false);
                bearPos.SetActive(false);
                dog.SetActive(true);
                dogPos.SetActive(true);
          
        }
             //check if the dog is in position
            if (dog.transform.position == dogPos.transform.position)
            {
            //if so then hide the dog, and its target and show the next animal
                dog.SetActive(false);
                dogPos.SetActive(false);
                cat.SetActive(true);
                catPos.SetActive(true);
            
          
          

           
        }
            //check if the cat is in position
           if (cat.transform.position == catPos.transform.position)
            {
            //if so then hide the cat, and its target and show the next animal
                cat.SetActive(false);
               catPos.SetActive(false);
               panel1.SetActive(false);
               nearMenu.SetActive(false);
              //also start a coroutine to show a checkmark and show the basketball scene
               StartCoroutine(makeObjectInActive());
               BasketBall.SetActive(true);
              
           
        }




        }
    //simple coroutine to show and hide a checkmark a predefined time has passed
    public IEnumerator makeObjectInActive()
    {
   
        Check.SetActive(true);
        
        yield return new WaitForSecondsRealtime(3);

        Destroy(Check);
            
   
    
    }
}


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
            if (bear.transform.position == bearPos.transform.position)
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
               panel1.SetActive(false);
             nearMenu.SetActive(false);

               StartCoroutine(makeObjectInActive());
               BasketBall.SetActive(true);
              
           
        }




        }
    public IEnumerator makeObjectInActive()
    {
       
        Check.SetActive(true);
        
        yield return new WaitForSecondsRealtime(3);

        Destroy(Check);
            
   
    
    }
}


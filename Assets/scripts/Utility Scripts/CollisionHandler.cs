using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public GameObject bb1;
    public GameObject bb2;
    public GameObject bb3;
    public GameObject Check;
    public GameObject next;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //check if all basketballs have been set to false
        if(bb1.activeSelf == false && bb2.activeSelf == false && bb3.activeSelf == false)
        {
            //if so start the coroutine to show the next prompt
            StartCoroutine(makeObjectInActive());
        }
    }

    //method to check for collisions with a trigger placed in basketball hoop
    public void OnTriggerEnter(Collider other)
    {
        //if the tag is the first basketball then deactivate it and spawn the next two
        if(other.gameObject.tag == "bb1")
        {
            other.gameObject.SetActive(false);
            bb2.SetActive(true);
            bb3.SetActive(true);
        }
        //else just deactivate whatever interacts with it, which should only be the other balls
        else
        {
            other.gameObject.SetActive(false);
        }


    }
    //simple coroutine to make a checkmark appear, wait, then show the next prompt and hide the checkmark again
    public IEnumerator makeObjectInActive()
    {

        Check.SetActive(true);
        yield return new WaitForSecondsRealtime(3);
        next.SetActive(true);
        Destroy(Check);



    }
}

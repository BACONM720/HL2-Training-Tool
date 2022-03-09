using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public GameObject bb1;
    public GameObject bb2;
    public GameObject bb3;
    public GameObject Check;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(bb1.activeSelf == false && bb2.activeSelf == false && bb3.activeSelf == false)
        {
            StartCoroutine(makeObjectInActive());
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "bb1")
        {
            other.gameObject.SetActive(false);
            bb2.SetActive(true);
            bb3.SetActive(true);
        }
        else
        {
            other.gameObject.SetActive(false);
        }


    }

    public IEnumerator makeObjectInActive()
    {

        Check.SetActive(true);

        yield return new WaitForSecondsRealtime(3);

        Destroy(Check);



    }
}

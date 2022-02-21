using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public GameObject bb1;
    public GameObject bb2;
    public GameObject bb3;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
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
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
   

    public Transform goal;
    public GameObject g;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (g.transform.position == goal.position)
        {
            RemoveRigid();
        }
      
    }

    public void RemoveRigid()
    {
       
       //g.GetComponent<Rigidbody>().detectCollisions = false;
       //g.GetComponent<Rigidbody>().useGravity = false;
       Increase_Size.FreezePos2(g.GetComponent<Rigidbody>());


    }
}

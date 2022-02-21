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
        RemoveRigid();
      
    }

    public void RemoveRigid()
    {
        if(g.transform.position == goal.position)
        {
            Destroy(g.GetComponent<Rigidbody>());
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Increase_Size : MonoBehaviour
{

   public Rigidbody r;
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody>();
        r.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void IncreaseSize(GameObject g)
    {
        g.transform.localScale += new Vector3((float)0.2, (float)0.2, (float)0.2);
    }

    public static void DecreaseSize(GameObject g)
    {
        g.transform.localScale -= new Vector3((float)0.2, (float)0.2, (float)0.2);
     
    }

    public static void FreezePos(Rigidbody r)
    {
        
        r.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotation;
    }

    public static void FreezePos2(Rigidbody r)
    {

        r.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotation;
    }

    public static void unFreezePos(Rigidbody r)
    {
        r.constraints = RigidbodyConstraints.None;
        r.constraints = RigidbodyConstraints.FreezeRotation;


    }

}

using UnityEngine;

public class Increase_Size : MonoBehaviour
{

   public Rigidbody r;
    // Start is called before the first frame update
    void Start()
    {
        //get objects rigidbody
        r = GetComponent<Rigidbody>();
        //set objects initial constraints to prevent rotation and movement
        r.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //simple static method to increase object scale
    public static void IncreaseSize(GameObject g)
    {
        g.transform.localScale += new Vector3((float)0.2, (float)0.2, (float)0.2);
    }
    //static method to decrease object scale
    public static void DecreaseSize(GameObject g)
    {
        g.transform.localScale -= new Vector3((float)0.2, (float)0.2, (float)0.2);
     
    }
    //static method to freese object position and prevent movement or rotation
    //except in the y position as if the user drops an object I want it to fall
    public static void FreezePos(Rigidbody r)
    {
        r.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotation;
    }

    //second static freexe method that adds constraints to all tranforms of the object
    public static void FreezePos2(Rigidbody r)
    {

        r.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotation;
    }

    //static method to unfreeze an object and allow movement
    //rotation is still frozen to prevent the user placing the object in a weird rotation
    public static void unFreezePos(Rigidbody r)
    {
        r.constraints = RigidbodyConstraints.None;
        r.constraints = RigidbodyConstraints.FreezeRotation;


    }

}

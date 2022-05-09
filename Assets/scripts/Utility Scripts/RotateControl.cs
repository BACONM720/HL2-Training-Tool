using Microsoft.MixedReality.Toolkit.UI.BoundsControl;
using UnityEngine;

public class RotateControl : MonoBehaviour
{
    public GameObject car;
    public bool correct;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if the rotation of the car is in range then set it to the correct rotation, disable the ability to rotate and set the correct flag to true
        if (transform.localRotation.eulerAngles.z < 20 && transform.localRotation.eulerAngles.z > -20) {
            correct = true;
            gameObject.transform.rotation = car.transform.rotation;
            gameObject.GetComponent<BoundsControl>().enabled = false;

        }
    }

}

using Microsoft.MixedReality.Toolkit.UI.BoundsControl;
using UnityEngine;

public class size_controller : MonoBehaviour
{

    public bool correct;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if the roses scale is within range then set it to the pink roses scale, remove the ability to scale and set the correct flag to true
        if (transform.localScale.x > 1.45 && transform.localScale.y > 1.45 && transform.localScale.z > 1.45)
        {
            correct = true;
            gameObject.transform.localScale = new Vector3((float)1.5, (float)1.5, (float)1.5);
            gameObject.GetComponent<BoundsControl>().enabled = false;
        }
       
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLetters : MonoBehaviour
{
    // Start is called before the first frame update#
    public GameObject letters;
    public Transform letterPos;
    public GameObject playButton;

    void Start()
    {
        StartCoroutine(moveLetter());
    }

    // Update is called once per frame
    void Update()
    {   transform.position = Vector3.Lerp(letters.transform.position,letterPos.position, 0.5f * Time.deltaTime);
       
    }

    IEnumerator moveLetter()
    {  // Rigidbody[] allChildren = letters.GetComponentsInChildren<Rigidbody>();
       
       //yield return new WaitForSecondsRealtime(6);
      //  foreach(Rigidbody child in allChildren)
       // {
        //    float speed = 110;

        //    child.isKinematic = false;

         //   Vector3 force = transform.forward;
          //  force = new Vector3(0, 0 , force.z);
          //  child.AddForce(force * speed);
        //}
        yield return new WaitForSeconds(10);
        letters.SetActive(false);
        playButton.SetActive(true);

      
      

    }
}

using System.Collections;
using UnityEngine;

public class moveLetters : MonoBehaviour
{
    public GameObject letters;
    public Transform letterPos;
    public GameObject playButton;

    void Start()
    {
        ///coroutine is called onload
        StartCoroutine(moveLetter());
    }

    // Update is called once per frame
    void Update()
    {   //move the set of letters to a goal positon in front of the user using a Lerp movement
        transform.position = Vector3.Lerp(letters.transform.position,letterPos.position, 0.5f * Time.deltaTime);
       
    }

    //coroutine to simply hide the letters and show the play button after 10 seconds have passed
    IEnumerator moveLetter()
    { 
        yield return new WaitForSeconds(10);
        letters.SetActive(false);
        playButton.SetActive(true);

      
    }
}

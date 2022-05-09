using Microsoft.MixedReality.Toolkit.UI.BoundsControl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject Rose;
	public GameObject Car;
	public GameObject Car1;
	public GameObject ScaleObjs;
	public GameObject RotateObjs;
	public GameObject MenuScale;
	public GameObject Check;
	public GameObject next;


	// Start is called before the first frame update
	void Start()
    {

    }

    // Update is called once per frame
    void Update()
		//check to make sure object is not null
    {if (Rose != null)
		{
			//if the size controller bool 'correct' is true then start the coroutine
			if (Rose.GetComponent<size_controller>().correct)
			{

				StartCoroutine(makeObjectInActive(ScaleObjs, RotateObjs));

			}
		}
	//check to make sure object isnt null 
		if (Car != null)
		{
			//if the rotation controller bool 'correct' is true then start the coroutine and show the next prompt
			if (Car.GetComponent<RotateControl>().correct)
			{
			
				StartCoroutine(makeObjectInActive(RotateObjs,null));
				next.SetActive(true);
			}
		}

		
         }		
			
		//coroutine to hide and show objects after waiting certain times
		public IEnumerator makeObjectInActive(GameObject g, GameObject j )
	{
		//show checkmark
		Check.SetActive(true);
		//wait three seconds
		yield return new WaitForSeconds(3);
		//destroy object g
		Destroy(g);
		//wait another second
		yield return new WaitForSeconds(1);
		//show object j
		j.SetActive(true);
		//hide checkmark
		Check.SetActive(false);
		
		
	

			}
	
	}

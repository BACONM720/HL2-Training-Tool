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
    {if (Rose != null)
		{
			if (Rose.GetComponent<size_controller>().correct)
			{

				StartCoroutine(makeObjectInActive(ScaleObjs, RotateObjs));

			}
		}
		if (Car != null)
		{

			if (Car.GetComponent<RotateControl>().correct)
			{
			
				StartCoroutine(makeObjectInActive(RotateObjs,null));
				next.SetActive(true);
			}
		}

		
         }		
			
			



     
	public IEnumerator makeObjectInActive(GameObject g, GameObject j )
	{
		Check.SetActive(true);
		yield return new WaitForSeconds(3);
		Destroy(g);
		
		yield return new WaitForSeconds(1);
	
		j.SetActive(true);

		Check.SetActive(false);
		
		
	

			}
	
	}

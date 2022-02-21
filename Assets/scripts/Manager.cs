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
	public GameObject BothObjs;
	public GameObject Check;
	public GameObject Shark;

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
				/*Car.transform.rotation = Car1.transform.rotation;
				Car.GetComponent<BoundsControl>().enabled = false;*/
				StartCoroutine(makeObjectInActive(RotateObjs, BothObjs));


			}
		}

		if (Shark != null)
		{
			if (Shark.transform.localScale.x < 0.5 && Shark.transform.localRotation.eulerAngles.x < 0) {
				Shark.GetComponent<ScaleHandlesConfiguration>().ShowScaleHandles = false;
				if (Shark.transform.localRotation.eulerAngles.x > 0 && Shark.transform.localRotation.eulerAngles.y < 90 || Shark.transform.localRotation.eulerAngles.y > 90 && Shark.transform.localRotation.eulerAngles.z < 0 || Shark.transform.localRotation.eulerAngles.z > 0)
				{
						StartCoroutine(makeObjectInActive(BothObjs, null));
				}
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
		/*
		public IEnumerator FadeOutObject(GameObject objToFade)
		{
			// Get the mesh renderer of the object
			MeshRenderer meshRenderer = objToFade.GetComponent<MeshRenderer>();

			// Get the color value of the main material
			Color color = meshRenderer.materials[0].color;


			// While the color's alpha value is above 0
			while (color.a > 0)
			{
				// Reduce the color's alpha value
				color.a -= 0.f;

				// Apply the modified color to the object's mesh renderer
				meshRenderer.materials[0].color = color;

				// Wait for the frame to update
				yield return new WaitForEndOfFrame();
			}

			// If the material's color's alpha value is less than or equal to 0, end the coroutine
			yield return new WaitUntil(() => meshRenderer.materials[0].color.a <= 0f);
		}
		*/
	}

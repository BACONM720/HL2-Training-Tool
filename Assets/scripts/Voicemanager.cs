using Microsoft.MixedReality.Toolkit.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voicemanager : MonoBehaviour
{
    public GameObject j;
         public GameObject i;

    bool move;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (move)
        {
            i.transform.position = Vector3.Lerp(i.transform.position, j.transform.position, 3 * Time.deltaTime);
        }

    }

    public void deleteOBJ(GameObject g)
    {
        g.SetActive(false);
    }

    public void spawn(GameObject g)
    {
        g.SetActive(true);
    }

    public void moveObj()
    {
        move = true;

    }
}

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
        //if the object flag move is true then move the object to the goal using lerp 
        if (move)
        {
            i.transform.position = Vector3.Lerp(i.transform.position, j.transform.position, 3 * Time.deltaTime);
        }

    }
    // simple hide obj method
    public void deleteOBJ(GameObject g)
    {
        g.SetActive(false);
    }

    //simple spawn obj method
    public void spawn(GameObject g)
    {
        g.SetActive(true);
    }
    //simple method to set flag to true
    public void moveObj()
    {
        move = true;

    }
}

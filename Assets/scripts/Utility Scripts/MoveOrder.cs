using System.Collections;
using UnityEngine;

public class MoveOrder : MonoBehaviour
{
    public GameObject pawn1;
    public GameObject pawn2;
    public GameObject pawn3;
    public GameObject Knight1;
    public GameObject Knight2;
    public GameObject Bishop1;
    public GameObject Bishop2;
    public GameObject Rook;

    public GameObject pawn1B;
    public GameObject pawn2B;
    public GameObject pawn3B;
    public GameObject Knight1B;
    public GameObject Knight2B;
    public GameObject Bishop1B;
    public GameObject Bishop2B;
    public GameObject RookB;
    public GameObject QueenB;

    public GameObject pawn1Pos;
    public GameObject pawn2Pos;
    public GameObject pawn3Pos;
    public GameObject Knight1Pos;
    public GameObject Knight2Pos;
    public GameObject Bishop1Pos;
    public GameObject Bishop2Pos;
    public GameObject RookPos;


    public GameObject pawn1BPos;
    public GameObject pawn2BPos;
    public GameObject pawn3BPos;
    public GameObject Knight1BPos;
    public GameObject Knight2BPos;
    public GameObject Knight1BinPos;
    public GameObject Knight2BinPos;
    public GameObject Bishop1BPos;
    public GameObject Bishop2BPos;
    public GameObject RookBPos;
    public GameObject QueenBPos;

    public GameObject nextBanner;

    public int speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //check if pawn has been moved to its correct position
        //if so then carry out the set of moves, which wil set the pawn in proper position, spawn the bishops position and move the black pawn
        if (pawn1.transform.position == pawn1Pos.transform.position)
        {
            MoveSet(pawn1, pawn1Pos, Bishop1Pos, pawn1B, pawn1BPos);
         
        }
        //this process is repeated for the bishop
        if(Bishop1.transform.position == Bishop1Pos.transform.position)
        {
            MoveSet(Bishop1, Bishop1Pos, pawn2Pos, Bishop1B, Bishop1BPos);
      
        }

        if (pawn2.transform.position == pawn2Pos.transform.position)
        {
            MoveSet(pawn2, pawn2Pos, Knight1Pos, pawn2B, pawn2BPos);
          
        }
        //the knight could not use the standard move set call
        //there is a special coroutine in order to move the black knight required

        if (Knight1.transform.position == Knight1Pos.transform.position)
        {
            //set in position
            Knight1.transform.position = Knight1Pos.transform.position;
            //hide its goal marker
            Knight1Pos.SetActive(false);
            //start coroutine to move black knight
            StartCoroutine(MoveKnight1());
            //show next pieces goal marker
            pawn3Pos.SetActive(true);
            //add all constraints to knight
            Increase_Size.FreezePos2(Knight1.GetComponent<Rigidbody>());
        }

        if (pawn3.transform.position == pawn3Pos.transform.position)
        {
            MoveSet(pawn3, pawn3Pos, Knight2Pos, pawn3B, pawn3BPos);
          
        }
        //again repeat process for the second knight
        if (Knight2.transform.position == Knight2Pos.transform.position)
        {
            Knight2.transform.position = Knight2Pos.transform.position;
            Knight2Pos.SetActive(false);
            StartCoroutine(MoveKnight2());
   
            Bishop2Pos.SetActive(true);
            Increase_Size.FreezePos2(Knight2.GetComponent<Rigidbody>());
        }

        
        if (Bishop2.transform.position == Bishop2Pos.transform.position)
        {
            MoveSet(Bishop2, Bishop2Pos, RookPos, RookB, RookBPos);
           
        }

        //rook uses the same move set although there are no more goal positions to spawn.
        if (Rook.transform.position == RookPos.transform.position)
        {
            Rook.transform.SetPositionAndRotation(RookPos.transform.position, new Quaternion(0, 0, 0, 0));
            RookPos.SetActive(false);
            QueenB.transform.position = Vector3.Lerp(QueenB.transform.position, QueenBPos.transform.position, speed * Time.deltaTime);
            nextBanner.SetActive(true);
            Increase_Size.FreezePos2(Rook.GetComponent<Rigidbody>());
        }

    }

    //first knight coroutine movement
    public IEnumerator MoveKnight1()
    {
        //use an initial Lerp to move the knight up and above the pieces
        Knight1B.transform.position = Vector3.Lerp(Knight1B.transform.position, Knight1BinPos.transform.position, speed * Time.deltaTime);
        
        //wait 1 second
        yield return new WaitForSeconds(1);

        //use another Lerp movement to move the black knight to its target position
        Knight1BinPos.transform.position = Vector3.Lerp(Knight1B.transform.position, Knight1BPos.transform.position, speed * 150* Time.deltaTime);

        yield break;
        

    }

    //coroutine to move the second black knight
    public IEnumerator MoveKnight2()
    {
        //use an initial Lerp to move the knight up and above the pieces
        Knight2B.transform.position = Vector3.Lerp(Knight2B.transform.position, Knight2BinPos.transform.position, speed * Time.deltaTime);
        
        //wait 1 second
        yield return new WaitForSeconds(1);

        //use another Lerp movement to move the black knight to its target position
        Knight2BinPos.transform.position = Vector3.Lerp(Knight2B.transform.position, Knight2BPos.transform.position, speed * 150 * Time.deltaTime);

        yield break;
    }

    //main set of moves defined in a method for readability
    public void MoveSet(GameObject w, GameObject wp, GameObject wpn, GameObject b, GameObject bp)
    {
        //set the transform of the piece to its target position
        w.transform.SetPositionAndRotation(wp.transform.position, new Quaternion(0, 0, 0, 0));
        //hide the previous goal marker
        wp.SetActive(false);
        //show the next goal marker
        wpn.SetActive(true);
        //move the next black piece using lerp to its position
        b.transform.position = Vector3.Lerp(b.transform.position, bp.transform.position, speed * Time.deltaTime);
        //freeze the piece in position to prevent any further interactions
        Increase_Size.FreezePos2(w.GetComponent<Rigidbody>());
    }
}


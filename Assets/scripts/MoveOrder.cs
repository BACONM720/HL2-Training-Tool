using MRTK.Tutorials.GettingStarted;
using System.Collections;
using System.Collections.Generic;
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
        if (pawn1.transform.position == pawn1Pos.transform.position)
        {
            MoveSet(pawn1, pawn1Pos, Bishop1Pos, pawn1B, pawn1BPos);
         
        }

        if(Bishop1.transform.position == Bishop1Pos.transform.position)
        {
            MoveSet(Bishop1, Bishop1Pos, pawn2Pos, Bishop1B, Bishop1BPos);
      
        }

        if (pawn2.transform.position == pawn2Pos.transform.position)
        {
            MoveSet(pawn2, pawn2Pos, Knight1Pos, pawn2B, pawn2BPos);
          
        }

        if (Knight1.transform.position == Knight1Pos.transform.position)
        {
            Knight1.transform.position = Knight1Pos.transform.position;
            Knight1Pos.SetActive(false);
           
            StartCoroutine(MoveKnight1());
         
            pawn3Pos.SetActive(true);
            Increase_Size.FreezePos2(Knight1.GetComponent<Rigidbody>());
        }

        if (pawn3.transform.position == pawn3Pos.transform.position)
        {
            MoveSet(pawn3, pawn3Pos, Knight2Pos, pawn3B, pawn3BPos);
          
        }

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

      
        if (Rook.transform.position == RookPos.transform.position)
        {
        
            Rook.transform.SetPositionAndRotation(RookPos.transform.position, new Quaternion(0, 0, 0, 0));
            RookPos.SetActive(false);
            QueenB.transform.position = Vector3.Lerp(QueenB.transform.position, QueenBPos.transform.position, speed * Time.deltaTime);
            nextBanner.SetActive(true);
            Increase_Size.FreezePos2(Rook.GetComponent<Rigidbody>());
        }

    }

    public IEnumerator MoveKnight1()
    {
        
        Knight1B.transform.position = Vector3.Lerp(Knight1B.transform.position, Knight1BinPos.transform.position, speed * Time.deltaTime);
        
        yield return new WaitForSeconds(1);

        Knight1BinPos.transform.position = Vector3.Lerp(Knight1B.transform.position, Knight1BPos.transform.position, speed * 150* Time.deltaTime);

        yield break;
        

    }
    public IEnumerator MoveKnight2()
    {
        
        Knight2B.transform.position = Vector3.Lerp(Knight2B.transform.position, Knight2BinPos.transform.position, speed * Time.deltaTime);

        yield return new WaitForSeconds(1);

        Knight2BinPos.transform.position = Vector3.Lerp(Knight2B.transform.position, Knight2BPos.transform.position, speed * 150 * Time.deltaTime);

        yield break;
    }
    public void MoveSet(GameObject w, GameObject wp, GameObject wpn, GameObject b, GameObject bp)
    {
        w.transform.SetPositionAndRotation(wp.transform.position, new Quaternion(0, 0, 0, 0));
        wp.SetActive(false);
        wpn.SetActive(true);
        b.transform.position = Vector3.Lerp(b.transform.position, bp.transform.position, speed * Time.deltaTime);
        Increase_Size.FreezePos2(w.GetComponent<Rigidbody>());
    }
}


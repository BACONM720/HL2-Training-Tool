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
            pawn1.transform.position = pawn1Pos.transform.position;
            pawn1Pos.SetActive(false);
            Bishop1Pos.SetActive(true);
            pawn1B.transform.position = Vector3.Lerp(pawn1B.transform.position, pawn1BPos.transform.position, speed * Time.deltaTime);
        }

        if(Bishop1.transform.position == Bishop1Pos.transform.position)
        {
            Bishop1.transform.position = Bishop1Pos.transform.position;
            Bishop1Pos.SetActive(false);
            pawn2Pos.SetActive(true);
            Bishop1B.transform.position = Vector3.Lerp(Bishop1B.transform.position, Bishop1BPos.transform.position, speed * Time.deltaTime);
        }

        if (pawn2.transform.position == pawn2Pos.transform.position)
        {
            pawn2.transform.position = pawn2Pos.transform.position;
            pawn2Pos.SetActive(false);
            Knight1Pos.SetActive(true);
            pawn2B.transform.position = Vector3.Lerp(pawn2B.transform.position, pawn2BPos.transform.position, speed * Time.deltaTime);
        }

        if (Knight1.transform.position == Knight1Pos.transform.position)
        {
            Knight1.transform.position = Knight1Pos.transform.position;
            Knight1Pos.SetActive(false);
           
            StartCoroutine(MoveKnight1());
         
            pawn3Pos.SetActive(true);
         }

        if (pawn3.transform.position == pawn3Pos.transform.position)
        {
            pawn3.transform.position = pawn3Pos.transform.position;
            pawn3Pos.SetActive(false);
            Knight2Pos.SetActive(true);
            pawn3B.transform.position = Vector3.Lerp(pawn3B.transform.position, pawn3BPos.transform.position, speed * Time.deltaTime);
        }

        if (Knight2.transform.position == Knight2Pos.transform.position)
        {
            Knight2.transform.position = Knight2Pos.transform.position;
            Knight2Pos.SetActive(false);
            StartCoroutine(MoveKnight2());
   
            Bishop2Pos.SetActive(true);
             }

        
        if (Bishop2.transform.position == Bishop2Pos.transform.position)
        {
            Bishop2.transform.position = Bishop2Pos.transform.position;
            Bishop2Pos.SetActive(false);
            RookPos.SetActive(true);
            RookB.transform.position = Vector3.Lerp(RookB.transform.position, RookBPos.transform.position, speed * Time.deltaTime);
        }

      
        if (Rook.transform.position == RookPos.transform.position)
        {
            Rook.transform.position = RookPos.transform.position;
            RookPos.SetActive(false);
            QueenB.transform.position = Vector3.Lerp(QueenB.transform.position, QueenBPos.transform.position, speed * Time.deltaTime);
            nextBanner.SetActive(true);
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
}

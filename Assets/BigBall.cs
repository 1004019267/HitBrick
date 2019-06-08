using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBall : MonoBehaviour {
    public GameObject getBig;
    Move move;
    int ballScore=40;
	// Use this for initialization
	void Start () {
        move = FindObjectOfType<Move>();
	}
	
	// Update is called once per frame
	void Update () {    
        if (move.score-ballScore>=0)
        {
            ballScore = 40 + ballScore;
          var go=  Instantiate(getBig);
            go.transform.position = new Vector3(Random.Range(-move.maxX,move.maxX),8,0);
        }
	}
}

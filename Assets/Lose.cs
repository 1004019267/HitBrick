using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose : MonoBehaviour {
    public GameObject Last;
    Move move;
    UI ui;
	// Use this for initialization
	void Start () {
        move = FindObjectOfType<Move>();
        ui = FindObjectOfType<UI>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        int maxScore = PlayerPrefs.GetInt("maxScore");
        if (move.score>maxScore)
        {
            maxScore = move.score;
            PlayerPrefs.SetInt("maxScore", maxScore);
        }
        ui.End(move.score,maxScore);
        Last.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}

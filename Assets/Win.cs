using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Win : MonoBehaviour {
    public GameObject win1;
    Ball ball;
    Move move;
    GetBirck geB;
	// Use this for initialization
	void Start () {
        geB = FindObjectOfType<GetBirck>();
        move = FindObjectOfType<Move>();
        ball = FindObjectOfType<Ball>();   
        this.gameObject.GetComponent<Button>().onClick.AddListener(()=> {      
            Time.timeScale = 1;
           ball.isGo = true;
            geB.getSpeeds.Clear();
            geB.getBirck();     
            win1.gameObject.SetActive(false);   
        });
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI : MonoBehaviour {
    Text score;
    public  Text lastScore;
    public Text winScore;
	// Use this for initialization
	void Start () {
        score = GameObject.Find("Text").GetComponent<Text>();     
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Look(int score1)
    {
        score.text = "分数" + score1;
    }
    public void End(int score1,int maxscore)
    {
        lastScore.text = "分数" + score1 + "最高分" + maxscore;
        
    }
    public void Win(int score1, int maxscore)
    {
winScore.text = "分数" + score1 + "最高分" + maxscore;
    }
}

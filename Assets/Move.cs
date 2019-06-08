using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public int score = 0;
    // Use this for initialization
    public delegate void Score(int score);
    public static Score scoreAdd;
    UI ui;
    GetBirck getB;
    public GameObject win;
   public bool isEnd=true;

   public float maxX;
    float halfBoard;
    Ball ball;
    Rigidbody2D ballBody;
    
	void Start () {
        
        getB = FindObjectOfType<GetBirck>();
        ui = FindObjectOfType<UI>();
        scoreAdd += this.AddScore;
        Vector3 rect = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
       halfBoard= this.GetComponent<Renderer>().bounds.size.x / 2;
        maxX = rect.x - halfBoard;
        ball = FindObjectOfType<Ball>();
        ballBody = ball.GetComponent<Rigidbody2D>();
	}
    void OnDestroy()
    {
        scoreAdd-= this.AddScore;
    }
    public void AddScore(int score1=1)
    {
        score += score1;
        ui.Look(score);
    }
    // Update is called once per frame
    void Update()
    {
        var moP = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        moP.z = 0;
        moP.y = -4.45f;
        //transform.position = new Vector3(moP.x,transform.position.y,transform.position.z);
        moP.x = Mathf.Clamp(moP.x, -maxX, maxX);
        transform.position = moP;      
        if (getB.bricks.Count<=0&&isEnd)
        {
            isEnd = false;
            int maxScore = PlayerPrefs.GetInt("maxScore");
            if (score > maxScore)
            {
                maxScore = score;
                PlayerPrefs.SetInt("maxScore", maxScore);
            }
            ui.Win(score, maxScore);        
            Time.timeScale = 0;
            win.gameObject.SetActive(true);         
            ball.transform.position = new Vector3(transform.position.x, transform.position.y + 0.75f, 0);
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (ball.isGo==false)
        {
            Vector3 dir = Vector3.Normalize(ball.transform.position - transform.position);
        dir.z = 0;
        ballBody.velocity = dir * (ball.speed+Ball.getSpeed);
        }        
    }
  
}

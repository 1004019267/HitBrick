using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public int speed = 5;
    public static int getSpeed = 0;
   public bool isGo=true;
    public GameObject gameStar;
    Move move;
    // Use this for initialization
    void Start () {
        move = FindObjectOfType<Move>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)&&isGo)
        {
            gameStar.SetActive(false);
            isGo = false;
            transform.GetComponent<Rigidbody2D>().velocity = Vector2.up * (speed+getSpeed);
        }
        if (isGo)
        {
            transform.position =new Vector3(move.transform.position.x,move.transform.position.y+0.75f,0);
        }
	}
}

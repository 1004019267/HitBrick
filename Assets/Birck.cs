using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birck : MonoBehaviour {
    public int hp = 1;
    SpriteRenderer spR;
    Move move;
    GetBirck geB;
	// Use this for initialization
    
	void Start () {
        geB = FindObjectOfType<GetBirck>();
        move = FindObjectOfType<Move>();
        spR = GetComponent<SpriteRenderer>();
        switch (hp)
        {
            case 2: spR.color = Color.red; break;
            case 3: spR.color = Color.blue; break;
            case 4: spR.color = Color.yellow; break;
            case 5: spR.color = Color.green; break;
            case 6: spR.color = Color.black; break;
            case 7: spR.color = Color.cyan; break;
            case 8: spR.color = Color.gray; break;
            case 9: spR.color = Color.magenta; break;
            default:
                spR.color = Color.white;
                break;
        }
    }
	
	// Update is called once per frame
	void Update () {		
	}
    void OnCollisionEnter2D(Collision2D other)
    {
        if (hp>0)
        {
            hp--;
            switch (hp)
            {
                case 2: spR.color = Color.red; break;
                case 3: spR.color = Color.blue; break;
                case 4: spR.color = Color.yellow; break;
                case 5: spR.color = Color.green; break;
                case 6: spR.color = Color.black; break;
                case 7: spR.color = Color.cyan; break;
                case 8: spR.color = Color.gray; break;
                case 9: spR.color = Color.magenta; break;
                default:
                    spR.color = Color.white;
                    break;
            }
            move.AddScore();
            if (hp<=0)
            {
                geB.bricks.Remove(this.gameObject);
                Destroy(this.gameObject);
            }        
        }
    }
}

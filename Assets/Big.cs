using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Big : MonoBehaviour {
    Ball ball;
	// Use this for initialization
	void Start () {
        ball = FindObjectOfType<Ball>();
        Destroy(this.gameObject, 5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {     
            ball.transform.localScale += Vector3.one*0.2f;
            Destroy(this.gameObject);
        }
        if (other.CompareTag("Palyer")&&ball.transform.localScale.x>0.2)
        {
            ball.transform.localScale -= Vector3.one * 0.15f;
            Destroy(this.gameObject);
        }
        
    }
}

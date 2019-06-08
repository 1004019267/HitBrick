using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RePlay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Time.timeScale = 1;
            Ball.getSpeed = 1;
            Application.LoadLevel(0);
        }
	}
}

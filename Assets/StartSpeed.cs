using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSpeed : MonoBehaviour
{
    // Use this for initialization
    Move move;
    void Start()
    {
        move = FindObjectOfType<Move>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Ball.getSpeed++;
        if (move.gameObject.transform.localScale.x < 3.5)
        {
            move.gameObject.transform.localScale = new Vector3(move.gameObject.transform.localScale.x + 0.1f, 1, 1);
        }
        Destroy(this.gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBirck : MonoBehaviour
{
    public List<GameObject> bricks = new List<GameObject>();
    public GameObject brick;
    public Transform parent;
    Move move;
    int num;
    public GameObject getSpeed;
    public List<GameObject> getSpeeds = new List<GameObject>();
    // Use this for initialization
    void Start()
    {
        move = FindObjectOfType<Move>();
        getBirck();

    }
    public void getBirck()
    {
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                var go = Instantiate(brick);
                go.transform.position = new Vector3((3 * i - 8), j + 1, 0);
                go.GetComponent<Birck>().hp = Random.Range(1 + num, 4 + num);
                go.transform.SetParent(parent);
                bricks.Add(go);
            }
        }

        for (int i = 0; i < bricks.Count; i++)
        {
            if (Random.Range(0,3)== Random.Range(0, 3))
            {                                       
                getSpeeds.Add(bricks[i].gameObject);
                Destroy(bricks[i].gameObject);
                bricks.Remove(bricks[i].gameObject);
               
            }
        }      
            var go1 = Instantiate(getSpeed); go1.transform.position = getSpeeds[Random.Range(0, getSpeeds.Count)].transform.position;     
        move.isEnd = true;
        num++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

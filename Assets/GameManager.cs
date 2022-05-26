using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public GameObject ballPrefab;
    void Update()
    {
        GameObject ballObj = GameObject.Find("Ball");
    if(ballObj == null)
        {
            GameObject newBall = Instantiate(ballPrefab);
            newBall.name = ballPrefab.name; 
        }
    }
}

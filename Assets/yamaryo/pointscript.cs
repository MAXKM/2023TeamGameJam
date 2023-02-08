using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class pointscript : MonoBehaviour
{
    int score;

    public GameObject scoreText;
   
    public void get10score()
    {
        score += 10;
    }

    public void get30score()
    {
        score += 30;
    }

    public void get50score()
    {
        score += 50;
    }

    public void get100score()
    {
        score += 100;
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GameObject.Find("score");
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.GetComponent<Text>().text = score.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resultScript : MonoBehaviour
{
    public Text ScoreText;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        score = scoreScript.getscore();
        ScoreText.text = string.Format("score:{0}", score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

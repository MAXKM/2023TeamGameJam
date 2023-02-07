using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour
{
    public Text scoretext;
    public static int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "10")
        {
            score += 10;
            scoretext.text = string.Format("score:{0}", score);
        }

        if (collision.gameObject.tag == "30")
        {
            score += 30;
            scoretext.text = string.Format("score:{0}", score);
        }

        if (collision.gameObject.tag == "Targer50")
        {
            score += 50;
            scoretext.text = string.Format("score:{0}", score);
        }

        if (collision.gameObject.tag == "Targer100")
        {
            score += 100;
            scoretext.text = string.Format("score:{0}", score);
        }
    }

    public static int getscore()
    {
        return score;
    }
}

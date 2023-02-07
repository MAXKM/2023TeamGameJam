using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour
{
    public Text scoretext;
    public static int score;
    //public score30Script

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "B")
        {
            score += 10;
            scoretext.text = string.Format("score:{0}", score);
        }

        if (collision.gameObject.tag == "30")
        {
            score += 30;
            scoretext.text = string.Format("score:{0}", score);
        }

        if (collision.gameObject.tag == "50")
        {
            score += 50;
            scoretext.text = string.Format("score:{0}", score);
        }

        if (collision.gameObject.tag == "100")
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

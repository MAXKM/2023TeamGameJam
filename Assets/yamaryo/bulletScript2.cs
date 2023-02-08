using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bulletScript2 : MonoBehaviour
{
    //public static int score;
   // private Text scoretext;
    public GameObject manager;

    public void Shoot(Vector3 power)
    {
        GetComponent<Rigidbody>().AddForce(power);
    }

    void Start()
    {
        Application.targetFrameRate = 60;
        //scoretext = GameObject.Find("score").GetComponent<Text>();
        //score = 0;
        manager = GameObject.Find("gamemanager");
    }

    void Update()
    {
        //âÊñ äOÇ…èoÇΩÇÁãÖÇÕè¡ñ≈
        if (transform.position.z < -15)
        {
            Destroy(gameObject);
        }

    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name + " ìñÇΩÇËÇ‹ÇµÇΩ");
        Destroy(collision.gameObject);

        /*int getscore2()
        {
            if (collision.gameObject.tag == "10")
            {
                score += 10;
                scoretext.text = string.Format("score:{0}", score);
                return score;
            }


            if (collision.gameObject.tag == "30")
            {
                score += 30;
                scoretext.text = string.Format("score:{0}", score);
                return score;
            }

            if (collision.gameObject.tag == "50")
            {
                score += 50;
                scoretext.text = string.Format("score:{0}", score);
                    return score;
            }

            if (collision.gameObject.tag == "100")
            {
                score += 100;
                scoretext.text = string.Format("score:{0}", score);
                    return score;
            }

            return score;
        }*/
        
        if (collision.gameObject.tag == "10")
        {
            manager.GetComponent<pointscript>().get10score();
            //scoretext.text = string.Format("score:{0}", score);

        }

        if (collision.gameObject.tag == "30")
        {
            manager.GetComponent<pointscript>().get30score();
        }

        if (collision.gameObject.tag == "50")
        {
            manager.GetComponent<pointscript>().get50score();
            //scoretext.text = string.Format("score:{0}", score);
        }

        if (collision.gameObject.tag == "100")
        {
            manager.GetComponent<pointscript>().get100score();
            //scoretext.text = string.Format("score:{0}", score);
        }

    }

    
    /*public static int getscore()
    {
        return score;
    }*/
}    
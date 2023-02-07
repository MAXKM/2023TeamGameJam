using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score30Script : MonoBehaviour
{
    public Text scoretext;
    public static int score;
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
            socreScript.score += 30;
            scoretext.text = string.Format("score:{0}", score);
        }
    }
    
    
}

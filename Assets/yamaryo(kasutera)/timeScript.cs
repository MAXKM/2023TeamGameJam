using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeScript : MonoBehaviour
{
    public Text TimeText;
    public  float time;
    public GameObject on_time;
    public GameObject stop;

    public   bool actime;

    float stoptime;


    // Start is called before the first frame update
    void Start()
    {
        stoptime = randomtimeScript.randomtime;
        //stoptime = randomtimeScript.getrandomtime();

        on_time = GameObject.Find("gamemanager(kas)");

        stop = GameObject.Find("stopbutton");
    }

    // Update is called once per frame
    void Update()
    {
        if(on_time.GetComponent<gameScript2>().mvtime == true)
        {
            if(stop.GetComponent<stopbuttonScript2>().b_stop == false)
            {
                time += Time.deltaTime;
                TimeText.text = time.ToString("F2");
                if(randomtimeScript.randomtime / 3 <= time)
                {
                    actime = true;
                }

            }
            
        }

    }

    /*public static  float  gettime()
    {
        return time;
    }*/

}

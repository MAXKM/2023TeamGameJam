using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class gameScript2 : MonoBehaviour
{
    public GameObject startpanel;
    public GameObject stop_button;
    public GameObject timetext;

    public GameObject good;
    public GameObject bad;
    public GameObject soso;
    public GameObject normal;

    public GameObject startbutton;
    public GameObject stopbutton;

    public bool mvtime;

    public  float time;

    public randomtimeScript randomtime;

    float stoptime;
    float curtime;
    
    


    public enum SceneState
    {
        Start, //スタート画面(目標タイム表示)
        GamePlay, //ゲームプレイ画面
        Result, //リザルト画面
    }

    //現在のシーンの状態
    SceneState currentScene = SceneState.Start;

    // Start is called before the first frame update
    void Start()
    {
        startbutton = GameObject.Find("startbutton");
        stopbutton = GameObject.Find("stopbutton");
        

        //stoptime = randomtimeScript.getrandomtime();
        //curtime = timeScript.gettime();
    }

    // Update is called once per frame
    void Update()
    {

        switch (currentScene)
        {
            case SceneState.Start:
                //スタート画面の処理
                startpanel.SetActive(true);
                stop_button.SetActive(false);
                timetext.SetActive(false);

                normal.SetActive(false);
                good.SetActive(false);
                bad.SetActive(false);
                soso.SetActive(false);


                if (startbutton.GetComponent<startbuttonScript2>().b_start == true)
                {
                    currentScene = SceneState.GamePlay;
                }

                break;

            case SceneState.GamePlay:
                //ゲームプレイ画面の処理
                startpanel.SetActive(false);
                stop_button.SetActive(true);

                normal.SetActive(true);
                good.SetActive(false);
                bad.SetActive(false);
                soso.SetActive(false);


                time += Time.deltaTime;

                if (randomtimeScript.randomtime / 3 > time)
                {
                    timetext.SetActive(true);
                }
                else
                {
                    timetext.SetActive(false);
                }

               
                mvtime = true;

                if (stopbutton.GetComponent<stopbuttonScript2>().b_stop == true)
                {
                    currentScene = SceneState.Result;
                }

                break;

            case SceneState.Result:
                //リザルト画面の処理
                startpanel.SetActive(false);
                stop_button.SetActive(false);
                timetext.SetActive(true);

                if (randomtimeScript.randomtime - time >= -1f && randomtimeScript.randomtime - time <= 1f)
                {
                    normal.SetActive(false);
                    good.SetActive(true);
                    bad.SetActive(false);
                    soso.SetActive(false);

                }

                else if (randomtimeScript.randomtime - time >= -2f && randomtimeScript.randomtime - time <= 2f)
                {
                    normal.SetActive(false);
                    good.SetActive(false);
                    bad.SetActive(false);
                    soso.SetActive(true);
                }

                else if(randomtimeScript.randomtime - time < -2f)
                {
                    normal.SetActive(false);
                    good.SetActive(false);
                    bad.SetActive(true);
                    soso.SetActive(false);
                }

                



                break;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class gameScript2 : MonoBehaviour
{
    public GameObject startpanel;
    public GameObject stop_button;
    public GameObject timetext;


    public GameObject startbutton;
    public GameObject stopbutton;

    public bool mvtime;

    private  float time;

    public randomtimeScript randomtime;

    float stoptime;
    float curtime;
    
    


    public enum SceneState
    {
        Start, //�X�^�[�g���(�ڕW�^�C���\��)
        GamePlay, //�Q�[���v���C���
        Result, //���U���g���
    }

    //���݂̃V�[���̏��
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
                //�X�^�[�g��ʂ̏���
                startpanel.SetActive(true);
                stop_button.SetActive(false);
                timetext.SetActive(false);

                if (startbutton.GetComponent<startbuttonScript2>().b_start == true)
                {
                    currentScene = SceneState.GamePlay;
                }

                break;

            case SceneState.GamePlay:
                //�Q�[���v���C��ʂ̏���
                startpanel.SetActive(false);
                stop_button.SetActive(true);

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
                //���U���g��ʂ̏���
                startpanel.SetActive(false);
                stop_button.SetActive(false);
                timetext.SetActive(true);




                break;
        }
    }
}

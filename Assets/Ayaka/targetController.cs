using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        //50ポイントの的
        if (gameObject.tag == "50")
        {
            transform.Translate(-0.05f, 0, 0);
        }

        //100ポイントの的
        if (gameObject.tag == "100")
        {
            transform.Translate(-0.1f, 0, 0);
        }

        //画面外に出たら的は消滅
        if (transform.position.x < 0)
        {
            Destroy(gameObject);
        }     
    }
}

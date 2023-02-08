using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetGenerator50 : MonoBehaviour
{
    public GameObject Target50Prefab;
    float span50 = 1.0f;
    float delta = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;

        //50ポイントの的生成
        if (this.delta > this.span50)
        {
            GameObject item = Instantiate(Target50Prefab);
            item.transform.position = new Vector3(7.0f, 2.83f, -13.0f);

            this.delta = 0.0f;
        }
    }
}

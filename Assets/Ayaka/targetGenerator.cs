using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetGenerator : MonoBehaviour
{
    public GameObject Target100Prefab;
    public GameObject Target50Prefab;
    public GameObject Target30Prefab;
    public GameObject Target10Prefab;

    float span100 = 3.0f;
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

        
        //100ポイントの的生成
        if (this.delta > this.span100)
        {
            GameObject go = Instantiate(Target50Prefab);
            go.transform.position = new Vector3(-10, 0, 0);
        }

        //50ポイントの的生成
        if (this.delta > this.span50)
        {
            GameObject go = Instantiate(Target100Prefab);
            go.transform.position = new Vector3(-10.0f, 0.0f, 3.0f);
        }
        this.delta = 0.0f;


    }
}

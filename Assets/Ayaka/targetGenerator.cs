using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetGenerator : MonoBehaviour
{
    public GameObject Target100Prefab;

    float span100 = 3.0f;
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
            GameObject item = Instantiate(Target100Prefab);
            item.transform.position = new Vector3(-12.5f, 0.0f, 0.9f);

            this.delta = 0.0f;
        }
    }
}

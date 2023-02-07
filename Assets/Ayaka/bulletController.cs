using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController : MonoBehaviour
{
    public void Shoot(Vector3 power)
    {
        GetComponent<Rigidbody>().AddForce(power);
    }


    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        //画面外に出たら球は消滅
        if (transform.position.y < -20)
        {
            Destroy(gameObject);
        }
    }
}

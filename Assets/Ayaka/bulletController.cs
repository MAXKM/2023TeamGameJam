using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController : MonoBehaviour
{
    public GameObject manager;

    public void Shoot(Vector3 power)
    {
        GetComponent<Rigidbody>().AddForce(power);
    }

    void Start()
    {
        Application.targetFrameRate = 60;

        manager = GameObject.Find("bulletGenerator");
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

        if (collision.gameObject.tag == "10")
        {
            manager.GetComponent<PointDirector>().get10score();
        }

        if (collision.gameObject.tag == "30")
        {
            manager.GetComponent<PointDirector>().get30score();
        }

        if (collision.gameObject.tag == "50")
        {
            manager.GetComponent<PointDirector>().get50score();
        }

        if (collision.gameObject.tag == "100")
        {
            manager.GetComponent<PointDirector>().get100score();
        }

    }
}

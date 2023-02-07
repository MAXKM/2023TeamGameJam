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
        //âÊñ äOÇ…èoÇΩÇÁãÖÇÕè¡ñ≈
        if (transform.position.y < -20)
        {
            Destroy(gameObject);
        }
    }

    //ìñÇΩÇ¡ÇΩÇÁìIè¡ñ≈
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name + " ìñÇΩÇËÇ‹ÇµÇΩ");
        Destroy(collision.gameObject);
    }
}

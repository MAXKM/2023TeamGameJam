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
        
        /*
        //����������I����
        void OnCollisionEnter(Collider other)
        {
            Destroy(gameObject);
        }
        

        //��ʊO�ɏo����I�͏���
        if (transform.position.y > -50)
        {
            Destroy(gameObject);
        }
        */
    }
}

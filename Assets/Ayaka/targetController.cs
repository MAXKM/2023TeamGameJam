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
        //50�|�C���g�̓I
        if (gameObject.tag == "Targer50")
        {
            transform.Translate(-0.05f, 0, 0);
        }

        //100�|�C���g�̓I
        if (gameObject.tag == "Targer100")
        {
            transform.Translate(-0.1f, 0, 0);
        }

        //��ʊO�ɏo����I�͏���
        if (transform.position.x > 10)
        {
            Destroy(gameObject);
        }

        
        
       
    }
    //����������I����
    void OnCollisionEnter(Collider collision)
    {

        Debug.Log("������܂���");
        Destroy(collision.gameObject);
    }
}

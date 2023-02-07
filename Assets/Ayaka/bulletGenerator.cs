using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletGenerator : MonoBehaviour
{
    public GameObject BulletPrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //�N���b�N���ꂽ�炻�̕����ɋ����o��
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(BulletPrefab);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            bullet.GetComponent<bulletController>().Shoot(worldDir.normalized * 2000);
        }
    }
}


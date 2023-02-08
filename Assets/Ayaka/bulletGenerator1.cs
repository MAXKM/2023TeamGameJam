using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletGenerator1 : MonoBehaviour
{
    public GameObject SpherePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(SpherePrefab);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worlddir = ray.direction;
            bullet.GetComponent<bulletController>().Shoot(worlddir.normalized * 700);
        }       
    }
}

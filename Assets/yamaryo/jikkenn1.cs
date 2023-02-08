using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jikkenn1 : MonoBehaviour
{
    public static int score;
    public Text scoretext;
    

    public GameObject SpherePrefab;

    //public GameObject text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(SpherePrefab);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worlddir = ray.direction;
            bullet.GetComponent<bulletScript2>().Shoot(worlddir.normalized * 1500);


        }
    }
   
    public static int getscore()
    {
        return score;
    }
}


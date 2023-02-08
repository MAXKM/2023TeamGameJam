using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bulletGenerator1 : MonoBehaviour
{
    public GameObject SpherePrefab;
    private int count = 5;
    private float time = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.count > 0 )
        {
            if (Input.GetMouseButtonDown(0))
            {
                GameObject bullet = Instantiate(SpherePrefab);

                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                Vector3 worlddir = ray.direction;
                bullet.GetComponent<bulletController>().Shoot(worlddir.normalized * 700);

                this.count -= 1;
            }
        }
        else
        {
            this.time += Time.deltaTime;
            if(this.time > 2.0f)
            {
                SceneManager.LoadScene("ResultScene");
            }
        }
    }
}

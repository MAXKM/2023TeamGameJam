using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramoveScript : MonoBehaviour
{
    public GameObject movebutton;
    public GameObject kasuterastart;

    public GameObject mvbtn;

    Vector3 tagetposi;

    // Start is called before the first frame update
    void Start()
    {
        mvbtn = GameObject.Find("movebutton");
        kasuterastart.SetActive(false);
        tagetposi = new Vector3(30, 1, -10);
    }

    // Update is called once per frame
    void Update()
    {
        if (mvbtn.GetComponent<movebuttonScript>().movebtn == true)
        {
            movebutton.SetActive(false);
            kasuterastart.SetActive(true);

            Camera camera = Camera.main;
            camera.gameObject.transform.position = Vector3.MoveTowards(camera.gameObject.transform.position, tagetposi, 0.05f);
        }
        
    }

    
}

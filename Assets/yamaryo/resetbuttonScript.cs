using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resetbuttonScript : MonoBehaviour
{
    public void OnClicked()
    {
        int backScene = SceneManager.GetActiveScene().buildIndex - 1;
        SceneManager.LoadScene(backScene);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

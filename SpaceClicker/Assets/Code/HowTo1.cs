using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowTo1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HowTo()
    {
        SceneManager.LoadScene("HowTo2");
    }
    public void HowTo2()
    {
        SceneManager.LoadScene("HowTo2");
    }
    public void HowTo3()
    {
        SceneManager.LoadScene("HowTo3");
    }
    public void goHome()
    {
        SceneManager.LoadScene("Title");
    }
}

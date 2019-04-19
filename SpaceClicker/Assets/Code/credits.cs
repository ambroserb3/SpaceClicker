using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class credits : MonoBehaviour
{
    public float ctimer;

    // Start is called before the first frame update
    void Start()
    {
        ctimer = 10; 
    }

    // Update is called once per frame
    void Update()
    {
        ctimer -= Time.deltaTime;
        if(ctimer <= 0)
        {
            SceneManager.LoadScene("Title");
        }

    }
}

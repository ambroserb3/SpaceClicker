using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class Timer : MonoBehaviour{
    public float time;
    public Text Clock;
    string timeFormatted;

    void Start(){
        time = 120f;
        if (GameObject.Find("SceneManager").GetComponent<SplashManager>().twoMin)
        {
            time = 120;
        }
        if (GameObject.Find("SceneManager").GetComponent<SplashManager>().fiveMin)
        {
            time = 300;

        }
        if (GameObject.Find("SceneManager").GetComponent<SplashManager>().tenMin)
        {
            time = 600;
        }

    }
    void Update(){
        time -= Time.deltaTime;
        //Displays timer in nice mm:ss formatt
        int minutes = Mathf.FloorToInt(time / 60F);
        int seconds = Mathf.FloorToInt(time - minutes * 60);
        Clock.text = string.Format("{0:0}:{1:00}", minutes, seconds);
        Defeat();
    }

    public void Defeat()
    {
        if (time <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
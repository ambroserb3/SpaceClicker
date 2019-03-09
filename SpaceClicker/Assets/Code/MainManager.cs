using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    public Text timer;
   
    [SerializeField]
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        timer.text = "5:00";
        time = 300;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if(time <= 0)
        {
            //SceneManager.LoadScene(4);
            Debug.Log("game over");
        }
        var timerFormatted = string.Format("{0:0}:{1:00}", Mathf.Floor(time / 60), time % 60);
        timer.text = timerFormatted;
    }
}

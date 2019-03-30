using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashManager : MonoBehaviour
{
    public GameObject SplashManage;
    [SerializeField]
    private float timer;


    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(SplashManage);

        timer = 0;
    }

    private void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Scene scene = SceneManager.GetActiveScene();
        if (scene.buildIndex == 0 && timer >= 3)
        {
            SceneManager.LoadScene(1);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SplashManager : MonoBehaviour
{
    public GameObject SplashManage;
    [SerializeField]
    private float timer;
    public int[] timelimit;
    public GameObject SceneManage;
    //Attach this script to a Dropdown GameObject
    Dropdown Dropdown;
    //This is the string that stores the current selection m_Text of the Dropdown
    string TimeChoice;
    //This Text outputs the current selection to the screen
    public Text m_Text;
    //This is the index value of the Dropdown
    int DropdownValue;

    public bool twoMin = false;
    public bool tenMin = false;
    public bool fiveMin = false;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(SplashManage);
        DontDestroyOnLoad(SceneManage);

        timer = 0;
        //Keep the current index of the Dropdown in a variable
        DropdownValue = Dropdown.value;
        //Change the message to say the name of the current Dropdown selection using the value
        TimeChoice = Dropdown.options[DropdownValue].text;
        //Change the onscreen Text to reflect the current Dropdown selection
        m_Text.text = TimeChoice;

        //Fetch the DropDown component from the GameObject
        Dropdown = GetComponent<Dropdown>();
        //Output the first Dropdown index value
        Debug.Log("Starting Dropdown Value : " + Dropdown.value);
    }

    // Update is called once per frame
    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.buildIndex == 0)
        {
            timer += Time.deltaTime;
            if (timer >= 3)
            {
                SceneManager.LoadScene(1);
            }
        }

        if (scene.buildIndex == 1)
        {
            SplashManage = GameObject.Find("SplashManager");
            //Keep the current index of the Dropdown in a variable
            DropdownValue = Dropdown.value;
            //Change the message to say the name of the current Dropdown selection using the value
            TimeChoice = Dropdown.options[DropdownValue].text;
            //Change the onscreen Text to reflect the current Dropdown selection
            m_Text.text = TimeChoice;
        }
    }

    public void SetTimeLimit() {
        switch (Dropdown.value)
        {
            case 0:
                print("2 min");
                twoMin = true;
                break;
            case 1:
                print("5 min");
                fiveMin = true;
                break;
            case 2:
                print("10 min");
                tenMin = true;
                break;
        }

    }
}

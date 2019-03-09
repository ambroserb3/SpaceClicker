using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconBehaviorScript : MonoBehaviour
{
    private GameObject self;
    private GameObject[] icons = new GameObject[6];
    // Start is called before the first frame update
    void Start()
    {
        self = GameObject.Find("TopBar");
        for (int ii=0; ii<6; ii++)
        {
            icons[ii] = self.transform.GetChild(ii).gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int ii=0; ii<6; ii++)
        {
            icons[ii].transform.GetChild(0).GetComponent<Text>().text = "11";
        }
    }
}

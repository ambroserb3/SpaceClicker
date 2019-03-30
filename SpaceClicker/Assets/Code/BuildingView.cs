using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingView : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject A;
    public static string[] BUILDING_NAMES = new string[5] {"Mine","Farm","Habitation","WTF","Synth"};
    private GameObject[] gameObjects = new GameObject[5];
    void Start()
    {
        float height = ((RectTransform)A.transform).rect.height + 15;
        Vector3 initialPosition = GameObject.Find("Building").transform.localPosition;
        for(int i = 0; i < BUILDING_NAMES.Length; i++){
            gameObjects[i] = Instantiate(A, new Vector3(0,0,0), Quaternion.identity) as GameObject;
            gameObjects[i].transform.parent = GameObject.Find("Content").transform;
            gameObjects[i].GetComponent<BuildingBehavior>().SetName(BUILDING_NAMES[i]);
            gameObjects[i].transform.localScale = new Vector3(1,1,1);
            gameObjects[i].transform.localPosition = initialPosition - new Vector3(0, height * (i+1), 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

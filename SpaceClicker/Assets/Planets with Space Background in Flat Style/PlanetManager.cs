using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetManager : MonoBehaviour
{
    public static int[] resources;

    // Start is called before the first frame update
    void Start()
    {
        resources = new int[6];
        resources[0] = 0;
        resources[1] = 0;
        resources[2] = 0;
        resources[3] = 0;
        resources[4] = 0;
        resources[5] = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("water").GetComponent<TextMesh>().text = "Water: " + resources[0];
        GameObject.Find("power").GetComponent<TextMesh>().text = "Power: " + resources[1];
        GameObject.Find("food").GetComponent<TextMesh>().text = "Food: " + resources[2];
        GameObject.Find("khyber").GetComponent<TextMesh>().text = "Khyber: " + resources[3];
        GameObject.Find("titanium").GetComponent<TextMesh>().text = "Titanium: " + resources[4];
        GameObject.Find("iridium").GetComponent<TextMesh>().text = "Iridium: " + resources[5];
    }

    public static int[] getResources()
    {
        return resources;
    }

}

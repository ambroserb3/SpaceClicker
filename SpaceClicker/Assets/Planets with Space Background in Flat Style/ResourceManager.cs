using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResourceManager : MonoBehaviour
{
    public static int[] resources;
    public int Khyber;
    public AudioSource RusticHour;

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
        RusticHour.Play(0);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("water").GetComponent<TextMesh>().text = "Water: " + resources[0];
        GameObject.Find("power").GetComponent<TextMesh>().text = "Power: " + resources[1];
        GameObject.Find("food").GetComponent<TextMesh>().text = "Food: " + resources[2];
        GameObject.Find("khyber").GetComponent<TextMesh>().text = "Khyber: " + resources[3];
        GameObject.Find("titanium").GetComponent<TextMesh>().text = "Titanium: " + resources[4];
        GameObject.Find("iridium").GetComponent<TextMesh>().text = " " + resources[5];
        Victory();

    }

    //1. Food and Water reach a certain amount = Population Victory
    //2. Metals reach a certain amount = Structure victory
    //3. When energy reaches a certain amount = Energy Victory

    public static int[] getResources()
    {
        return resources;
    }

    public int[] ToAdd(string buildingName, int[] buildings){
        return Code.Resources.GetOptimizedPlanetGeneration(buildingName, buildings).GetResources();
    }
    public void Victory()
    {
        if (resources[0] + resources[2] >= 200)
        {
            //SceneManager.LoadScene("PopVictory");
            Debug.Log("Population Victory");
            RusticHour.Stop();
        }
        if (resources[3] + resources[4] + resources[5] >= 200)
        {
            //SceneManager.LoadScene("StructureVictory");
            Debug.Log("Structure Victory");
            RusticHour.Stop();
        }
        if (resources[1] >= 200)
        {
            //SceneManager.LoadScene("EnergyVictory");
            Debug.Log("Energy Victory");
            RusticHour.Stop();
        }
    }
}

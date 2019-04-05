using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResourceManager : MonoBehaviour
{
    public static Code.Resources resources;
    public int Khyber;
    public AudioSource RusticHour;

    // Start is called before the first frame update
    void Start()
    {
        resources = new Code.Resources();
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        GameObject.Find("water").GetComponent<TextMesh>().text = "Water: " + resources.GetWater();
        GameObject.Find("power").GetComponent<TextMesh>().text = "Power: " + resources.GetPower();
        GameObject.Find("food").GetComponent<TextMesh>().text = "Food: " + resources.GetFood();
        GameObject.Find("khyber").GetComponent<TextMesh>().text = "Khyber: " + resources.GetKhyber();
        GameObject.Find("titanium").GetComponent<TextMesh>().text = "Titanium: " + resources.GetTitanium();
        GameObject.Find("iridium").GetComponent<TextMesh>().text = "Iridium: " + resources.GetIridium();
=======
        GameObject.Find("water").GetComponent<TextMesh>().text = "Water: " + resources[0];
        GameObject.Find("power").GetComponent<TextMesh>().text = "Power: " + resources[1];
        GameObject.Find("food").GetComponent<TextMesh>().text = "Food: " + resources[2];
        GameObject.Find("khyber").GetComponent<TextMesh>().text = "Khyber: " + resources[3];
        GameObject.Find("titanium").GetComponent<TextMesh>().text = "Titanium: " + resources[4];
        GameObject.Find("iridium").GetComponent<TextMesh>().text = " " + resources[5];
>>>>>>> fe6dd33d526fa2c9fc64ce9aec4bd23df130f331
        Victory();

    }

    //1. Food and Water reach a certain amount = Population Victory
    //2. Metals reach a certain amount = Structure victory
    //3. When energy reaches a certain amount = Energy Victory

    

    public static Code.Resources ToAdd(string buildingName, int[] buildings){
        return Code.Resources.GetOptimizedPlanetGeneration(buildingName, buildings);
    }
    public void Victory()
    {
        if (resources.GetWater() + resources.GetFood() >= 200)
        {
            //SceneManager.LoadScene("PopVictory");
            Debug.Log("Population Victory");
            RusticHour.Stop();
        }
        if (resources.GetKhyber() + resources.GetIridium() + resources.GetTitanium() >= 200)
        {
            //SceneManager.LoadScene("StructureVictory");
            Debug.Log("Structure Victory");
            RusticHour.Stop();
        }
        if (resources.GetPower() >= 200)
        {
            //SceneManager.LoadScene("EnergyVictory");
            Debug.Log("Energy Victory");
            RusticHour.Stop();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//commented to fix
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
        GameObject.Find("water").GetComponent<TextMesh>().text = " " + resources.GetWater();
        GameObject.Find("power").GetComponent<TextMesh>().text = " " + resources.GetPower();
        GameObject.Find("energyTotal").GetComponent<TextMesh>().text = " " + resources.GetPower();
        GameObject.Find("food").GetComponent<TextMesh>().text = " " + resources.GetFood();
        GameObject.Find("khyber").GetComponent<TextMesh>().text = " " + resources.GetKhyber();
        GameObject.Find("titanium").GetComponent<TextMesh>().text = " " + resources.GetTitanium();
        GameObject.Find("iridium").GetComponent<TextMesh>().text = " " + resources.GetIridium();
        Victory();
    }

    //1. Food and Water reach a certain amount = Population Victory
    //2. Metals reach a certain amount = Materials victory
    //3. When energy reaches a certain amount = Power Victory


    public static Code.Resources ToAdd(string planetName, int[] buildings){
        return Code.Resources.GetOptimizedPlanetGeneration(planetName, buildings);
    }
    public void Victory()
    {
        if(GameObject.Find("Population").GetComponent<Population>().population >= 99)
        {
            SceneManager.LoadScene("PopulationVictory");
            Debug.Log("Population Victory");
            RusticHour.Stop();
        }
        if (resources.GetKhyber() + resources.GetIridium() + resources.GetTitanium() >= 999)
        {
            SceneManager.LoadScene("MaterialsVictory");
            Debug.Log("Structure Victory");
            RusticHour.Stop();
        }
        if (resources.GetPower() >= 200)
        {
            SceneManager.LoadScene("PowerVictory");
            Debug.Log("Energy Victory");
            RusticHour.Stop();
        }
    }
}
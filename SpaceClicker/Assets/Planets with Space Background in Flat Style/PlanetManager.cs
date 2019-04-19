using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetManager : MonoBehaviour
{
    private Code.Resources resources;
    private int[] buildings;
    private Code.Resources perClick;
    private string name;
    public AudioSource BuildingNoise;
    public AudioSource ResourceNoise;


    // Start is called before the first frame update
    void Start()
    {
        resources = ResourceManager.resources;
        name = gameObject.name;
        
        buildings = new int[6];
        buildings[0] = 0;
        buildings[1] = 0;
        buildings[2] = 0;
        buildings[3] = 0;
        buildings[4] = 0;
        buildings[5] = 0;
    }

    // Update is called once per frame
    void Update()
    {
        resources = ResourceManager.resources;
        perClick = ResourceManager.ToAdd(name, buildings);
        
    }

    public bool build(string buildType)
    {
        
        if (buildType.Equals("Power"))
        {
            if (resources.compareCost("Power"))
            {
                BuildingNoise.Play(0);
                buildings[0]++;
                resources.removeCost("Power");
                GameObject.Find("Building counter").GetComponent<BuildingCounter>().addBuilding();
                return true;
                
            }

        }

        if (buildType.Equals("Mine"))
        {
            if (resources.compareCost("Mine"))
            {
                BuildingNoise.Play(0);
                buildings[1]++;
                resources.removeCost("Mine");
                GameObject.Find("Building counter").GetComponent<BuildingCounter>().addBuilding();
                return true;
                //GameObject.Find("Building counter").GetComponent<BuildingCounter>().addBuilding();
            }
        }

        if (buildType.Equals("Farm"))
        {
            if (resources.compareCost("Farm"))
            {
                BuildingNoise.Play(0);
                buildings[2]++;
                resources.removeCost("Farm");
                GameObject.Find("Building counter").GetComponent<BuildingCounter>().addBuilding();
                return true;
               // GameObject.Find("Building counter").GetComponent<BuildingCounter>().addBuilding();
            }
        }

        if (buildType.Equals("Habitation"))
        {
            if (resources.compareCost("Habitation"))
            {
                BuildingNoise.Play(0);
                buildings[3]++;
                resources.removeCost("Habitation");
                GameObject.Find("Building counter").GetComponent<BuildingCounter>().addBuilding();
                GameObject.Find("Population").GetComponent<Population>().IncreaseHabitations();
                return true;
                //GameObject.Find("Building counter").GetComponent<BuildingCounter>().addBuilding();
            }
        }

        if (buildType.Equals("WTF"))
        {
            if (resources.compareCost("WTF"))
            {
                BuildingNoise.Play(0);
                buildings[4]++;
                resources.removeCost("WTF");
                GameObject.Find("Building counter").GetComponent<BuildingCounter>().addBuilding();
                return true;
                //GameObject.Find("Building counter").GetComponent<BuildingCounter>().addBuilding();
            }
        }

        if (buildType.Equals("Synth"))
        {
            if (resources.compareCost("Synth"))
            {
                BuildingNoise.Play(0);
                buildings[5]++;
                resources.removeCost("Synth");
                GameObject.Find("Building counter").GetComponent<BuildingCounter>().addBuilding();
                return true;
                //GameObject.Find("Building counter").GetComponent<BuildingCounter>().addBuilding();
            }
        }

        return false;
    }

    private void OnMouseDown()
    {
        resources.addResources(perClick);
        ResourceManager.resources = resources;
        ResourceNoise.Play(0);
    }
}
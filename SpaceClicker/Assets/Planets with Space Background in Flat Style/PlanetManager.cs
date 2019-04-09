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

    public void build(string buildType)
    {
        BuildingNoise.Play(0);
        if (buildType.Equals("Power"))
        {
            if (resources.compareCost("Power"))
            {
                buildings[0]++;
                resources.removeCost("Power");
            }

        }

        if (buildType.Equals("Mine"))
        {
            if (resources.compareCost("Mine"))
            {
                buildings[1]++;
                resources.removeCost("Mine");
            }
        }

        if (buildType.Equals("Farm"))
        {
            if (resources.compareCost("Farm"))
            {
                buildings[2]++;
                resources.removeCost("Farm");
            }
        }

        if (buildType.Equals("Habitation"))
        {
            if (resources.compareCost("Habitation"))
            {
                buildings[3]++;
                resources.removeCost("Habitation");
            }
        }

        if (buildType.Equals("WTF"))
        {
            if (resources.compareCost("WTF"))
            {
                buildings[4]++;
                resources.removeCost("WTF");
            }
        }

        if (buildType.Equals("Synth"))
        {
            if (resources.compareCost("Synth"))
            {
                buildings[5]++;
                resources.removeCost("Synth");
            }
        }
    }

    private void OnMouseDown()
    {
        resources.addResources(perClick);
        ResourceManager.resources = resources;
    }
}
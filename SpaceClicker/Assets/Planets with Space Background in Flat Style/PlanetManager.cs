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
            buildings[0]++;
        }

        if (buildType.Equals("Mine"))
        {
            buildings[1]++;
        }

        if (buildType.Equals("B"))
        {
            buildings[2]++;
        }

        if (buildType.Equals("C"))
        {
            buildings[3]++;
        }

        if (buildType.Equals("D"))
        {
            buildings[4]++;
        }

        if (buildType.Equals("E"))
        {
            buildings[5]++;
        }
    }

    private void OnMouseDown()
    {
        print("huzzah");
        resources.addResources(perClick);
        ResourceManager.resources = resources;
    }
}

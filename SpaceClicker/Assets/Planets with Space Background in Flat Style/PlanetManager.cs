using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetManager : MonoBehaviour
{
    private Code.Resources resources;
    private int[] buildings;
    private Code.Resources onClick;
    private string name;
    public AudioSource BuildingNoise;

    // Start is called before the first frame update
    void Start()
    {
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
<<<<<<< HEAD
        resources = ResourceManager.resources;
        onClick = ResourceManager.ToAdd(name, buildings);
=======
        resources = ResourceManager.getResources();
        //onClick = ResourceManager.ToAdd(name, buildings);
>>>>>>> 2de0e0088c0ff71907a063fff20ade5fe8e24af2
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
<<<<<<< HEAD
        resources.addResources(onClick);
=======

        resources[0] += onClick[0];
        resources[1] += onClick[1];
        resources[2] += onClick[2];
        resources[3] += onClick[3];
        resources[4] += onClick[4];
        resources[5] += onClick[5];

>>>>>>> 2de0e0088c0ff71907a063fff20ade5fe8e24af2
        ResourceManager.resources = resources;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinentalManager : MonoBehaviour
{
    private int[] resources;
    private int[] buildings;

    // Start is called before the first frame update
    void Start()
    {
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
        resources = ResourceManager.getResources();
    }

    public void build(string buildType)
    {
        if (buildType.Equals("Mine"))
        {
            buildings[0]++;
        }
    }

    private void OnMouseDown()
    {
        print("huzzah");
        resources[0] = resources[0] + 5;
        resources[1] = resources[1] + 5 + 3 * buildings[1];
        resources[2] = resources[2] + 3;
        resources[3] = resources[3] + 1 + 20 * buildings[0];
        resources[4] = resources[4] + 2;
        resources[5] = resources[5] + 4;

        ResourceManager.resources = resources;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkManager : MonoBehaviour
{
    private int[] resources;
    private int[] buildings;

    // Start is called before the first frame update
    void Start()
    {
        buildings = new int[6];
    }

    // Update is called once per frame
    void Update()
    {
        resources = PlanetManager.getResources();
    }


    private void OnMouseDown()
    {
        print("huzzah");
        resources[0] = resources[0] + 5;
        resources[1] = resources[1] + 5;
        resources[2] = resources[2] + 3;
        resources[3] = resources[3] + 1;
        resources[4] = resources[4] + 2;
        resources[5] = resources[5] + 4;

        PlanetManager.resources = resources;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingCounter : MonoBehaviour{

    public Text buildingCount;
    public int buildings;
    public float subtime;
    void Start(){
        buildingCount.text = "";
        buildings = 0;
        subtime = 10;
}
    void Update(){
        buildingCount.text = "" + buildings;

        subtime -= Time.deltaTime;
        if (subtime <= 0)
        {
            resetsubtime();
            for (int i = 0; i < buildings; i++)
            {
                if (ResourceManager.resources.GetPower() > 0)
                    ResourceManager.resources.SetPower(ResourceManager.resources.GetPower() - 5);
                else
                    ResourceManager.resources.SetPower(0);
            }

            if (ResourceManager.resources.GetPower() > 0)
                ResourceManager.resources.SetPower(0);

        }
    }

    public void resetsubtime()
    {
        subtime = 10;
        //i++;
    }

    public void addBuilding(){
        buildings++;
    }
}
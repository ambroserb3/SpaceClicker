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
                ResourceManager.resources.SetPower(ResourceManager.resources.GetPower() - 5);
            }
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
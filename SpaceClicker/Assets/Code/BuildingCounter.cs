using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingCounter : MonoBehaviour{

    public Text buildingCount;
    public int buildings;
    void Start(){
        buildingCount.text = "";
        buildings = 0;
    }
    void Update(){
        buildingCount.text = "" + buildings;
    }
    public void addBuilding(){
        buildings++;
    }
}
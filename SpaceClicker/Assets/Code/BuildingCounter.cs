using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingCounter : MonoBehaviour{
    public int buildings;
    void Start(){
        buildings = 0;
    }
    void Update(){

    }
    public void addBuilding(){
        buildings++;
    }
}
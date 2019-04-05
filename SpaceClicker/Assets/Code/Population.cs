using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Population : MonoBehaviour{
    public int population;
    public int food;
    public int water;
    public float time;
    void Start(){
        
    }
    void Update(){
        food = ResourceManager.resources.GetResources()[1];
        water = ResourceManager.resources.GetResources()[0];
        time = GameObject.Find("Timer").GetComponent<Timer>().time;
    }
}
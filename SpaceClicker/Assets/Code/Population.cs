using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Population : MonoBehaviour{
    public int population;
    public Text pops;
    public int food;
    public int water;
    public float time;
    [SerializeField]
    private float subtime;
    private int Increase;
    private int i=0;


    void Start(){
        Increase = 20;
        subtime = 10;
    }
    void Update(){
        
        food = ResourceManager.resources.GetResources()[1];
        water = ResourceManager.resources.GetResources()[0];
        time = GameObject.Find("Timer").GetComponent<Timer>().time;
        subtime -= Time.deltaTime;    
        if (subtime <= 0){
            resetsubtime();
            if (food+water >= Increase){
                population+= 10;
                Increase += 30;
            }
        }
        

    }
    public void resetsubtime(){
        subtime =10;
        i++;
    }
}
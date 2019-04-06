using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Population : MonoBehaviour{
    public int population;
    public int food;
    public int water;
    public float time;
    private float subtime;
    private int[] Increase;
    private int i=0;
    private float ctime;
    void Start(){
        Increase = new int[6] {30,60,120,240,560,560};
        subtime = 10;
        ctime=120;
    }
    void Update(){
        food = ResourceManager.resources.GetResources()[1];
        water = ResourceManager.resources.GetResources()[0];
        time = GameObject.Find("Timer").GetComponent<Timer>().time;
        subtime=10-(ctime-time);
        print(subtime);
        if(subtime <= 0){
            resetsubtime();
            if (food+water >= inc(i)){
                population+= 10;
            }
        }

    }
    public void resetsubtime(){
        ctime=time;
        subtime =10;
        i++;

    }
    public int inc(int i){
        try{
            return Increase[i];
        }
        catch{
            return 560;
        }
    }
}
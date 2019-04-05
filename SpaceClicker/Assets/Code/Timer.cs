using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour{
    public float time;
    void Start(){
        time = 120f;
    }
    void Update(){
        time -= Time.deltaTime;
    }
}
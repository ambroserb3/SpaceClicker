using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuiltBuildingScript : MonoBehaviour
{
    public string buildingtype;
    public string planetcolliding;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Scroll View").GetComponent<ScrollRect>().vertical = false;
        gameObject.transform.position = Camera.main.ScreenToWorldPoint( new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0))+ new Vector3(0,0,5); 
    }
    public void SetType(string type)
    {
        buildingtype = type;
    }

    // Update is called once per frame
    void Update()
    {
        //print(buildingtype);
        gameObject.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0)) + new Vector3(0, 0, 10);
        if (Input.GetMouseButtonUp(0))
        {
            planetcolliding = WhatPlanet();
            print(planetcolliding);
            print(buildingtype);
            if (planetcolliding != "No-Planet"){
                GameObject.Find(planetcolliding).GetComponent<PlanetManager>().build(buildingtype);
                //GameObject.Find("Building counter").GetComponent<BuildingCounter>().addBuilding();
            }
            GameObject.Find("Scroll View").GetComponent<ScrollRect>().vertical = true;
            Destroy(gameObject);
        }
    }

    string WhatPlanet(){
        Vector2 DarkPlanetPos = new Vector2(GameObject.Find("Dark-Planet").transform.position.x,GameObject.Find("Dark-Planet").transform.position.y);
        Vector2 WaterPlanetPos = new Vector2(GameObject.Find("Water-Planet").transform.position.x,GameObject.Find("Water-Planet").transform.position.y);
        Vector2 SandPlanetPos = new Vector2(GameObject.Find("Sand-Planet").transform.position.x,GameObject.Find("Sand-Planet").transform.position.y);
        Vector2 EarthPlanetPos = new Vector2(GameObject.Find("Earth-Planet").transform.position.x,GameObject.Find("Earth-Planet").transform.position.y);

        if (Vector2.Distance(new Vector2(transform.position.x,transform.position.y),(DarkPlanetPos)) < 1){
            //print("DarkPlanet");
            return "Dark-Planet";
        }
        if (Vector2.Distance(new Vector2(transform.position.x,transform.position.y),(WaterPlanetPos)) < 1){
            //print("DarkPlanet");
            return "Water-Planet";
        }
        if (Vector2.Distance(new Vector2(transform.position.x,transform.position.y),(SandPlanetPos)) < 1){
            //print("DarkPlanet");
            return "Sand-Planet";
        }
        if (Vector2.Distance(new Vector2(transform.position.x,transform.position.y),(EarthPlanetPos)) < 1){
            //print("DarkPlanet");
            return "Earth-Planet";
        }
        return "No-Planet";
    }
    /*void OnMouseUp()
    {
        print(planetcolliding);
        Destroy(gameObject);
    }*/

    /*void OnTriggerEnter(Collider other)
    {
        print("hiay");
        planetcolliding = other.gameObject.name;
    }

    void OnTriggerExit(Collider other)
    {
        planetcolliding = "";
    }*/
}

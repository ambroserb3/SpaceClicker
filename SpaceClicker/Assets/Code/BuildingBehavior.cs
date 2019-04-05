using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingBehavior : MonoBehaviour
{
    public GameObject built;
    public GameObject builtBuilding;
    public string buildingname;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetName(string name)
    {
        buildingname = name;
        SetImage(buildingname);
        
    }
    public void SetImage(string name){
        gameObject.GetComponent<SpriteRenderer>().sprite = GameObject.Find("BuildingMenuImageManager").GetComponent<BuildingMenuImageManagerScript>().getSprite(name);
    }
    void OnMouseDown()
    {
        builtBuilding = Instantiate(built, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        builtBuilding.GetComponent<BuiltBuildingScript>().SetType(buildingname);
    }
}

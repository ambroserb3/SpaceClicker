using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuiltBuildingScript : MonoBehaviour
{
    public string buildingtype;
    public string planetcolliding;
    // Start is called before the first frame update
    void Start()
    {
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
            Destroy(gameObject);
        } 
    }
    void OnMouseUp()
    {
        print(planetcolliding);
        Destroy(gameObject);
    }

    void OnTriggerEnter(Collider other)
    {
        print("hiay");
        planetcolliding = other.gameObject.name;
    }

    void OnTriggerExit(Collider other)
    {
        planetcolliding = "";
    }
}

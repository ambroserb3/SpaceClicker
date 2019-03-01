using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetManager : MonoBehaviour
{
    public int water;

    // Start is called before the first frame update
    void Start()
    {
        water = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        print("huzzah");
        water++;
        GameObject.Find("water").GetComponent<TextMesh>().text = "Water: " + water;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingMenuImageManagerScript : MonoBehaviour
{
    public Sprite PowerImage;
    public Sprite MineImage;
    public Sprite BImage;
    public Sprite CImage;
    public Sprite EImage;
    public Sprite FImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Sprite getSprite(string name){
        if (name == "Power"){
            return PowerImage;
        }
        if (name == "Mine"){
            return MineImage;
        }
        return BImage;
    } 

    // Update is called once per frame
    void Update()
    {
        
    }
}

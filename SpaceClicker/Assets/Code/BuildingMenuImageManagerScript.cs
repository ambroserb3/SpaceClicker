using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingMenuImageManagerScript : MonoBehaviour
{
    public Sprite PowerImage;
    public Sprite MineImage;
    public Sprite FarmImage;
    public Sprite HabitationImage;
    public Sprite WTFImage;
    public Sprite SynthImage;

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
        if (name == "Farm"){
            return FarmImage;
        }
        if (name == "Habitation"){
            return HabitationImage;
        }
        if (name == "WTF"){
            return WTFImage;
        }
        if (name == "Synth"){
            return SynthImage;
        }
        return SynthImage;
    } 

    // Update is called once per frame
    void Update()
    {
        
    }
}

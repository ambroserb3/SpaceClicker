using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleVisibility : MonoBehaviour
{
    // Start is called before the first frame update
    bool visibility;
    void Start()
    {
        transform.GetChild(0).gameObject.SetActive(false);
        visibility = false;
    }
    
    public void ToggleState()
    {
        transform.GetChild(0).gameObject.SetActive(!visibility);
        visibility = !visibility;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

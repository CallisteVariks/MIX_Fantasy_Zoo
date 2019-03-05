using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ToggleImagebar : MonoBehaviour
{

    public GameObject imagebar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleImage()
    {
        imagebar.GetComponent<Image>();
        enabled = false;
    }
}

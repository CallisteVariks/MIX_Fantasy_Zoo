using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleImagebar : MonoBehaviour
{

    public GameObject imagebar;


    public void ToggleImage()
    {
        imagebar.SetActive(!imagebar.activeSelf);
    }
}

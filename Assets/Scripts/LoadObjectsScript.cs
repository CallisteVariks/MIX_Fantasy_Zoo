using System.Collections;
using System.Collections.Generic;
using GoogleARCore.Examples.HelloAR;
using GoogleARCore.Examples.ObjectManipulation;
using UnityEngine;

public class LoadObjectsScript : MonoBehaviour
{

    public AndyPlacementManipulator arManipulator;
    public HelloARController arController;
    public GameObject object3d;
    
    // Start is called before the first frame update

    public void LoadObject()
    {
      //  arController.AndyPlanePrefab = object3d;
        arManipulator.AndyPrefab = object3d;
    }
}

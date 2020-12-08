using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundingBoxStateController : MonoBehaviour
{
   

    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.OnGameStarted += newSessionStart;
        GameManager.Instance.OnGameFinished += newSessionEnd;

        //control: Bounding Box, ihren Box Collider und den Object Manipulator
        //mit enabled 

        //Ausnahme: BoundsControl: BoundingBox über Property "Active"
        GetComponent<Microsoft.MixedReality.Toolkit.UI.BoundsControl.BoundsControl>().Active = true;
        //Box Collider:
        GetComponent<Microsoft.MixedReality.Toolkit.UI.BoundsControl.BoundsControl>().TargetBounds.enabled = true;
        //Object Manipulator:
        GetComponent<Microsoft.MixedReality.Toolkit.UI.ObjectManipulator>().enabled = true;
        



    }


    private void newSessionStart()
    {
        //Ausnahme: BoundingBox über Property "Active"
        GetComponent<Microsoft.MixedReality.Toolkit.UI.BoundsControl.BoundsControl>().Active = false;
        //Box Collider:
        GetComponent<Microsoft.MixedReality.Toolkit.UI.BoundsControl.BoundsControl>().TargetBounds.enabled = false;
        //Object Manipulator:
        GetComponent<Microsoft.MixedReality.Toolkit.UI.ObjectManipulator>().enabled = false;
    }

    private void newSessionEnd()
    {
        //Ausnahme: BoundsControl: BoundingBox über Property "Active"
        GetComponent<Microsoft.MixedReality.Toolkit.UI.BoundsControl.BoundsControl>().Active = true;
        //Box Collider:
        GetComponent<Microsoft.MixedReality.Toolkit.UI.BoundsControl.BoundsControl>().TargetBounds.enabled = true;
        //Object Manipulator:
        GetComponent<Microsoft.MixedReality.Toolkit.UI.ObjectManipulator>().enabled = true;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

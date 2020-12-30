using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Microsoft.MixedReality.Toolkit.UI.BoundsControl;
using Microsoft.MixedReality.Toolkit.UI;

public class BoundingBoxStateController : MonoBehaviour
{
    void Start()
    {
        GameManager.Instance.OnGameStarted += NewSessionStart;
        GameManager.Instance.OnGameFinished += NewSessionEnd;
		
        GetComponent<BoundsControl>().Active = true;
        GetComponent<BoundsControl>().TargetBounds.enabled = true;
        GetComponent<ObjectManipulator>().enabled = true;
    }

    private void NewSessionStart()
    {
        GetComponent<BoundsControl>().Active = false;
        GetComponent<BoundsControl>().TargetBounds.enabled = false;
        GetComponent<ObjectManipulator>().enabled = false;
    }

    private void NewSessionEnd()
    {
        GetComponent<BoundsControl>().Active = true;
        GetComponent<BoundsControl>().TargetBounds.enabled = true;
        GetComponent<ObjectManipulator>().enabled = true;
    }
}

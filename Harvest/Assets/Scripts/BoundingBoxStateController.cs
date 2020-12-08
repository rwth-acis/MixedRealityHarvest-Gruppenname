using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Microsoft.MixedReality.Toolkit.UI.BoundsControl;
using Microsoft.MixedReality.Toolkit.UI;

public class BoundingBoxStateController : MonoBehaviour
{
    void Start()
    {
        GameManager.Instance.OnGameStarted += newSessionStart;
        GameManager.Instance.OnGameFinished += newSessionEnd;
		
        GetComponent<BoundsControl>().Active = true;
        GetComponent<BoundsControl>().TargetBounds.enabled = true;
        GetComponent<ObjectManipulator>().enabled = true;
    }

    private void newSessionStart()
    {
        GetComponent<BoundsControl>().Active = false;
        GetComponent<BoundsControl>().TargetBounds.enabled = false;
        GetComponent<ObjectManipulator>().enabled = false;
    }

    private void newSessionEnd()
    {
        GetComponent<BoundsControl>().Active = true;
        GetComponent<BoundsControl>().TargetBounds.enabled = true;
        GetComponent<ObjectManipulator>().enabled = true;
    }
}

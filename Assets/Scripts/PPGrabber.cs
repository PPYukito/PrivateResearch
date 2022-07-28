using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PPGrabber : MonoBehaviour
{
    public GameObject debugObj;

    private OVRGrabbable grabbingObject;

    private void Start()
    {
        debugObj.SetActive(false);
    }

    private void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        debugObj.SetActive(true);

        OVRGrabbable grabable = other.GetComponent<OVRGrabbable>();
        if (grabable != null)
        {
            
            grabbingObject = grabable;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        debugObj.SetActive(false);

        if (other.gameObject == grabbingObject.gameObject)
        {
            
            grabbingObject = null;
        }
    }
}

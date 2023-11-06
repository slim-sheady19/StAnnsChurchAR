using System.Collections;
using System.Collections.Generic;
using Google.XR.ARCoreExtensions;
using UnityEngine;

public class CheckDeviceCompatible : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Find the AREarthManager on the same GameObject.
        AREarthManager arEarthManager = GetComponent<AREarthManager>();
        if (arEarthManager == null)
        {
            Debug.LogError("What the...? There's no AREarthManager in here! You kidding me?");
            return;
        }

        // Call the IsGeospatialModeSupported method and log the result.
        FeatureSupported isSupported = arEarthManager.IsGeospatialModeSupported(GeospatialMode.Enabled);
        Debug.Log($"Geospatial mode support: {isSupported}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

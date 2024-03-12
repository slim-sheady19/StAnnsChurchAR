using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAndStopLocationServices : MonoBehaviour
{
    
    
    public void OnEnable()
    {
        Input.location.Start();
    }

    public void OnDisable()
    {
        Input.location.Stop();
    }

}

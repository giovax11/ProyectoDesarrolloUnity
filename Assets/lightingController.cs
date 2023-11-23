using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class lightingController : MonoBehaviour
{
    public GameObject flashlight;
    public bool activeFlash;
    
    // Start is called before the first frame update
    void Start()
    {
        activeFlash=false;
        flashlight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(activeFlash && Input.GetKeyDown(KeyCode.F)){
            activeFlash=false;
           flashlight.SetActive(false);

        }else if(!activeFlash && Input.GetKeyDown(KeyCode.F)){
             activeFlash=true;
             flashlight.SetActive(true);
        }
    }
}

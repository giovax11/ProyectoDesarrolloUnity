using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 look;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        look.x += Input.GetAxis("Mouse X");
         look.y += Input.GetAxis("Mouse Y");
        Debug.Log(look);
    }
}

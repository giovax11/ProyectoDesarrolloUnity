using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpscare_hall : MonoBehaviour
{
   
    public GameObject gramophone;
    private bool hasTriggered = false;

    private void OnTriggerEnter(Collider other){
         if (!hasTriggered && other.CompareTag("Player")){

         }
    }
   
}

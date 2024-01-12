using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateEnding : MonoBehaviour
{
    public GameObject monster;
    public GameObject trigger1;
    public GameObject trigger2;
    private bool hasTriggered = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

      private void OnTriggerEnter(Collider other)
    {

        if (!hasTriggered && other.CompareTag("Player"))
        { monster.SetActive(true);                     
          trigger2.SetActive(true); 
          trigger1.SetActive(true); 
          hasTriggered=true;
         }
    }
}

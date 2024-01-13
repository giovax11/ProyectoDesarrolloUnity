using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreemTrigger : MonoBehaviour
{
    public AudioSource scream;
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
        {
            hasTriggered = true;
            scream.Play();
        }
    }
}

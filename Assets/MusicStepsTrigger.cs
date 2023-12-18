using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicStepsTrigger : MonoBehaviour
{
    public GameObject gramophone;
    private bool hasTriggered = false;
    private AudioSource gramophoneAudio;

    private void Start()
    {
        gramophoneAudio = gramophone.GetComponent<AudioSource>();
        // Verifica si el componente AudioSource se ha encontrado correctamente
        if (gramophoneAudio == null)
        {
            Debug.LogError("El componente AudioSource no se ha encontrado en el objeto <link>gramophone</link>.");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!hasTriggered && other.CompareTag("Player"))
        {
           
            if (gramophoneAudio != null)
            {
                gramophoneAudio.Play();
                hasTriggered = true;
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Jumpscare_hall : MonoBehaviour
{
    public GameObject monster;
    public GameObject screamSource;
    private AudioSource screamAudio;
    private bool hasTriggered = false;
    private bool isMoving = false;

  private void Start()
    {
        screamAudio = screamSource.GetComponent<AudioSource>();
        if (screamAudio == null)
        {
            Debug.LogError("El componente AudioSource no se ha encontrado en el objeto <link>gramophone</link>.");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!hasTriggered && other.CompareTag("Player"))
        {
            monster.SetActive(true);
           if (screamAudio != null)
            {
                screamAudio.Play();}

            hasTriggered = true;
            isMoving = true;
        }
    }

    private void Update()
    {
        if (isMoving && monster!=null)
        {
            Vector3 movement = new Vector3(0, 0, 5.8f); 
;
            monster.transform.Translate(movement * 5 * Time.deltaTime);
             Destroy(monster, 4f);
        }
    }
}

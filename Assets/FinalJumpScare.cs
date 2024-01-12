using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalJumpScare : MonoBehaviour
{
    public GameObject monster;
     private bool hasTriggered = false;
    private bool isMoving = false;

    public Transform player;

    public Animator animator;

    private AudioSource screamAudio;


    void Start()
    {
    screamAudio = monster.GetComponent<AudioSource>();
    }

        private void OnTriggerEnter(Collider other)
    {

        if (!hasTriggered && other.CompareTag("Player"))
        {
            
        if (screamAudio != null)
            {
                screamAudio.Play();}
     
        
              if (animator)
        {
            animator.SetBool("Sprint_transition", true);
        }
            monster.SetActive(true);
            hasTriggered = true;
            isMoving = true;
        }
    }

    // Update is called once per frame
   void Update()
    {

        if (isMoving)
        {
            Vector3 direccion = player.position - monster.transform.position; // Cambiado a monster.transform.position
            direccion.Normalize();
            float velocidad = 15f;
            monster.transform.position += direccion * velocidad * Time.deltaTime;
        }
    }
}


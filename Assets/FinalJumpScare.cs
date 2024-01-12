using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PSXShaderKit;

public class FinalJumpScare : MonoBehaviour
{
    public GameObject monster;
     private bool hasTriggered = false;
    private bool isMoving = false;

    public Transform player;

    public Animator animator;

    private AudioSource screamAudio;

    public AudioSource endingAudio;

    
    private bool hasPlayedEndingAudio = false;


    public float distanceThreshold = 1.5f; 

    public GameObject monsterFinalJumpscareEnding;

    public PosterizeEffect posterize;

    public BadTVEffect tvEffect;

    public PSXPostProcessEffect pixelation;


    private float transitionDuration = 2f; 
    private float elapsedTime = 0f;


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
            float velocidad = 12f;
            monster.transform.position += direccion * velocidad * Time.deltaTime;
            float distance = Vector3.Distance(monster.transform.position, player.position);
              if (distance < distanceThreshold)
            {
                if(!hasPlayedEndingAudio){
                endingAudio.Play();
                hasPlayedEndingAudio=true;}
                monster.SetActive(false);
                monsterFinalJumpscareEnding.SetActive(true);
                elapsedTime += Time.deltaTime;
                float t = Mathf.Clamp01(elapsedTime / transitionDuration);
                posterize.level = Mathf.RoundToInt(Mathf.Lerp(60, 2, t));
                tvEffect.thickDistort = (float)Mathf.RoundToInt(Mathf.Lerp(0.3f, 10f, t));
                tvEffect.fineDistort = Mathf.RoundToInt(Mathf.Lerp(2.2f, 10f, t));
                pixelation._PixelationFactor=(Mathf.Lerp(0.3f, 0.17f, t));

            }
        }
    }
}


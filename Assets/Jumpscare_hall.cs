using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Jumpscare_hall : MonoBehaviour
{
    public GameObject monster;
    public GameObject screamSource;
    private AudioSource screamAudio;
    public AudioSource cursedAudio;
    private bool hasTriggered = false;
    private bool isMoving = false;
    private bool distortedCamera=false;
    public BadTVEffect tvEffect;

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
            distortedCamera=true;
            StartCoroutine(WaitAndPlayCursedAudio());

        }
    }

        private IEnumerator WaitAndPlayCursedAudio()
    {
        yield return new WaitForSeconds(6f);

        if (cursedAudio != null)
        {
            cursedAudio.Play();
        }
    }

    private void Update()
    {
        if (isMoving && monster!=null)
        {
            Vector3 movement = new Vector3(0, 0, 5.8f); 

            monster.transform.Translate(movement * 4 * Time.deltaTime);
             Destroy(monster, 4f);
        }
  if(distortedCamera ){
        tvEffect.thickDistort = (float)Mathf.RoundToInt(Mathf.Lerp(tvEffect.thickDistort, 1.5f, 10f));
        tvEffect.fineDistort = Mathf.RoundToInt(Mathf.Lerp(2.2f, 10f, 10f));
        }
    }
}

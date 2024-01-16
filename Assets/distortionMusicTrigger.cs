using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distortionMusicTrigger : MonoBehaviour
{
    public AudioSource song;
    public float pitchChangeDuration = 40f;  // Duración en segundos para cambiar el pitch
    private float targetPitch = -0.3f;  // Valor final del pitch    void Start()
    // Start is called before the first frame update
    void Start()
    {
          StartPitchTransition();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

       public void StartPitchTransition()
    {
        // Asegúrate de que el AudioSource esté presente
        if (song != null)
        {
            // Inicia la transición de pitch desde el valor actual hacia el objetivo en la duración especificada
            StartCoroutine(ChangePitchOverTime(song, song.pitch, targetPitch, pitchChangeDuration));
        }
    }

    private IEnumerator ChangePitchOverTime(AudioSource audioSource, float startPitch, float endPitch, float duration)
    {
        float elapsed = 0f;

        while (elapsed < duration)
        {
            // Calcula el nuevo pitch utilizando Lerp
            float newPitch = Mathf.Lerp(startPitch, endPitch, elapsed / duration);

            // Aplica el nuevo pitch al AudioSource
            audioSource.pitch = newPitch;

            // Incrementa el tiempo transcurrido
            elapsed += Time.deltaTime;

            // Espera al siguiente frame
            yield return null;
        }

        // Asegúrate de que el pitch llegue exactamente al valor final
        audioSource.pitch = endPitch;
    }
}

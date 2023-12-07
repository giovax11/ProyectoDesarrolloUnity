using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightSound : MonoBehaviour
{
    public AudioSource sonidoEncendidoApagado; // AudioSource para el sonido de encendido y apagado
    private bool linternaEncendida = false;

    void Update()
    {
        ControlSonidoLinternaTeclaF();
    }

    void ControlSonidoLinternaTeclaF()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            linternaEncendida = !linternaEncendida;

            ReproducirSonidoLinternaPorTiempo(0.4f);
           
        }
    }

    void ReproducirSonidoLinternaPorTiempo(float tiempo)
    {
        ReproducirSonidoLinterna(0.2f); // Inicia la reproducción desde el segundo 0.2
        Invoke("DetenerSonidoLinterna", tiempo);
    }

    void ReproducirSonidoLinterna(float inicio)
    {
        if (sonidoEncendidoApagado != null)
        {
            sonidoEncendidoApagado.time = inicio;
            sonidoEncendidoApagado.PlayScheduled(AudioSettings.dspTime); // Agrega un pequeño retardo para asegurar la sincronización
        }
    }

    void DetenerSonidoLinterna()
    {
        if (sonidoEncendidoApagado != null)
        {
            sonidoEncendidoApagado.Stop();
        }
    }
}

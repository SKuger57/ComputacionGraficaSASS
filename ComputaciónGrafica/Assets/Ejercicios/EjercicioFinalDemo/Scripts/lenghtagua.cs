using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class lenghtagua : MonoBehaviour
{
    [SerializeField] Slider sliVelocidad;
    [SerializeField] public Material Velocidad;
    //private ParticleSystemRenderer particleRenderer;


    private void Start()
    {
        //particleRenderer = GetComponent<ParticleSystemRenderer>();
    }

    private void Update()
    {
        // Multiply the HDR material's brightness property by the multiplier
        Velocidad.SetFloat("_Speed", (sliVelocidad.value));
    }
}






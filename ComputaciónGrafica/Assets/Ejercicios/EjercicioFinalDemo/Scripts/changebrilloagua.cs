using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class changebrilloagua : MonoBehaviour
{
    [SerializeField] Slider sliBrillo;
    [SerializeField] public Material brillo;
    //private ParticleSystemRenderer particleRenderer;


    private void Start()
    {
        //particleRenderer = GetComponent<ParticleSystemRenderer>();
    }

    private void Update()
    {
        // Multiply the HDR material's brightness property by the multiplier
        brillo.SetFloat("_DisolveEdgeThickness", (sliBrillo.value));
    }
}

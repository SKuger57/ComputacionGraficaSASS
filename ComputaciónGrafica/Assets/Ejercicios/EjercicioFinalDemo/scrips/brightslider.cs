using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.VFX;


public class brightslider : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] public VisualEffect vfxComponent;
    //private ParticleSystemRenderer particleRenderer;


    private void Start()
    {
        //particleRenderer = GetComponent<ParticleSystemRenderer>();
    }

    private void Update()
    {

        vfxComponent.SetFloat("brightness", (slider.value));
    }
}
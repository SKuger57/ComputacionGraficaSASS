using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class lenghtagua : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] ParticleSystem particleSystem;
   
   

    private void Start()
    {
       
        slider.onValueChanged.AddListener(OnDurationSliderValueChanged);
    }

   
    private void OnDurationSliderValueChanged(float value)
    {
        particleSystem.Stop();
        var mainModule = particleSystem.main;
        mainModule.startLifetime = value;
        mainModule.startSpeed = 0.5f+Mathf.Abs(value-2.8f);
        particleSystem.Play();
    }
}







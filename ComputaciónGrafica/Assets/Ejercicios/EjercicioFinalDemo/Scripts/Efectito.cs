using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Efectito : MonoBehaviour
{
    public float startValue = 1f;
    public float endValue = 0f;
    public float duration = 1f;
    public Material brillo;

    private bool isRunning = false;
    private float currentTime = 0f;

    void Start()
    {

    }

    private void OnMouseDown()
    {
        if (!isRunning)
        {
            StartCoroutine(WaitAndRunEffect());
        }
    }

    IEnumerator WaitAndRunEffect()
    {
        yield return new WaitForSeconds(0.9f); // Espera 1 segundo

        isRunning = true;
        currentTime = 0f;

        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
            float t = currentTime / duration;
            float currentValue = Mathf.Lerp(startValue, endValue, t);
            brillo.SetFloat("_Disolve", currentValue);
            yield return null;
        }

        // Invert startValue and endValue for the reverse effect
        float temp = startValue;
        startValue = endValue;
        endValue = temp;

        isRunning = false;
    }

    void Update()
    {
        // Puedes agregar cualquier lógica de actualización adicional aquí
    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EffectChanger : MonoBehaviour
{
    [SerializeField] public GameObject effect1, effect2, effect3, effect4;
    [SerializeField] public Button switchButton;

    private int counter = 0;

    void Start()
    {
        switchButton.onClick.AddListener(SwitchEffect);
    }

    void SwitchEffect()
    {
        if (counter == 0)
        {
            effect1.SetActive(true);
            effect4.SetActive(false);
            counter = 1;
        }
        else if (counter == 1 && !effect2.activeSelf)
        {
            effect1.SetActive(false);
            effect2.SetActive(true);
            counter = 2;
        }
        else if (counter == 2 && !effect3.activeSelf)
        {
            effect2.SetActive(false);
            effect3.SetActive(true);
            counter = 3;
        }
        else
        {
            effect3.SetActive(false);
            effect4.SetActive(true);
            counter = 0;
        }
    }
}


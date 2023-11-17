using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effectChanger : MonoBehaviour
{
    [SerializeField] public GameObject effect1, effect2, effect3, effect4,boton;
    int counter = 0;
    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {
      
    }
    public void switcher()
    {
        if(counter==0)
        {
            boton.SetActive(false);
            effect4.SetActive(false);
            effect1.SetActive(true);
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
            boton.SetActive(true);
            counter = 0;
        }
    }
}

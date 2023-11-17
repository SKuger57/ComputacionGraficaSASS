using UnityEngine;
using System.Collections;

public class loop : MonoBehaviour
{
    [SerializeField]public GameObject objectToActivate;
   

   
   public void restartvfx()
    { 
            if (objectToActivate.activeSelf)
            {
                objectToActivate.SetActive(false);
               
                objectToActivate.SetActive(true);
            }
           
        
    }

    
}


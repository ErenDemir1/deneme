using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dongu : MonoBehaviour
{
    
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i==5)
            {
                continue;
            }
            Debug.Log(i);
        }   
    }
   
  
    
}

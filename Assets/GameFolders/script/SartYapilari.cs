using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SartYapilari : MonoBehaviour
{
    [SerializeField] private int sayi;
    [SerializeField] bool ternaryIfDegisken;
    [SerializeField] string gun;
    void Start()
    {
        switch (gun) 
        {
            case "Pazartesi":
                Debug.Log("Secili gun Pazartesidirhaha.");
                    break;
            case "Sali":
                Debug.Log("Secili gun Salidýrhaha.");   
                    break;
            case "Carsamba":
                Debug.Log("Secili gun Carsambadirhaha.");   
                break;
            default:
                Debug.Log("Hicbir sart saglanmamaktadýrhaha.");
                break;






        }

        
        
        
         


    }
    private void IfElse()
    {
        int sayi = 20;
        if (sayi < 20)
        {
            Debug.Log("Verilen sayi 20 den kucuktur.");

        }
        else if (sayi > 20) 
        {
            Debug.Log("Verilen sayi 20 den buyuktur");
        }

        else
        {
            Debug.Log("Hicbir sart saglanmiyor");
        }
    }
    private void TernaryIfDeneme()
    {
        if (ternaryIfDegisken)
        {
            Debug.Log("True dondu");
        }
        else
        {
            Debug.Log("False dondu");
        }

        Debug.Log(ternaryIfDegisken ? "True dondu" : "False dondu");
    }  
    
    private void IfElseGunler()
    {
        if (gun == "Pazartesi")
        {
            Debug.Log("Secili gun Pazartesidir.");
        }
        else if (gun == "Sali")
        {
           // Debug.Log("Secili gun Salidýr.");
        }
        else if (gun == "Carsamba")
        {
           Debug.Log("Secili gun Carsambadýr.");
        }
        else
        {
            Debug.Log("Hicbir sart saglanmamaktadýr.");
        }
    }
}

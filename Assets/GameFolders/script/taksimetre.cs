using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class taksimetre : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI yolInput;
    [SerializeField] TextMeshProUGUI ucretText;

    double pricePerKm = 2.20, totalPrice = 10;
    string km;
    void Update()
    {
        km = yolInput.text;
        km = Convert.ToDouble(km);
        totalPrice += (km * pricePerKm);

        if (totalPrice > 20)
        {
            ucretText.text = $"Borcunuz : {totalPrice} TL";
        }
        else
        {
            ucretText.text = "Borcunuz = 20 TL";
        }
    }

    
}

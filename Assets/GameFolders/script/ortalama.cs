using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ortalama : MonoBehaviour

{
    [SerializeField] InputField ortalamaInput;
    [SerializeField] InputField matematikInput;
    [SerializeField] InputField fizikInput;
    [SerializeField] InputField kimyaInput;
    [SerializeField] InputField biyolojiInput;
    [SerializeField] InputField turkceInput;
    [SerializeField] Text basariText;
    
    double matematik, fizik, kimya, biyoloji, turkce, ort;

    void Start()
    {


    }

    public void Hesapla()
    {
        matematik = Convert.ToDouble(matematikInput.text);
        fizik = Convert.ToDouble(fizikInput.text);
        kimya = Convert.ToDouble(kimyaInput.text);    
        biyoloji = Convert.ToDouble(biyolojiInput.text);
        turkce = Convert.ToDouble(turkceInput.text);

        ort = (matematik + fizik + kimya + biyoloji + turkce) / 5;
        ortalamaInput.text = ort.ToString();

        if (ort > 60)
        {
            basariText.text = "Aferin gectin mq";
        }
          else
        {
            basariText.text = "Tembel oc";
        }









    }

   














} 

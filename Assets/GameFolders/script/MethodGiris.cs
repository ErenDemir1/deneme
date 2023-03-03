using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MethodGiris : MonoBehaviour
{
    [SerializeField] Text text;
    
    void Start()
    {
        //int result=DegerDondurenMethod();
        // result += 10;
        // text.text = result.ToString(); 
        //Parametre();
        //Parametre(10, 20, 100);
        //DefaultValueDeneme();

    }

    private void DegerDondurmeyenMethod()
    {
        int sayi1 = 10;
        int sayi2 = 20;

        int sonuc = sayi1 + sayi2;
        text.text = $"Sonuc: {sonuc}";
        text.color = Color.red;
    }
    private int DegerDondurenMethod()
    {
        int sayi1 = 10;
        int sayi2 = 20;

        int sonuc = sayi1 + sayi2;
        return sonuc;
    }
    private void Parametre()
    {
        int sayi1 = 10;
        int sayi2 = 20;

        int sonuc= sayi1    + sayi2;    
        text.text= sonuc.ToString();
    }
    private void Parametre(int sayi1, int sayi2)
    {
        int sonuc = sayi1 + sayi2;
        text.text = sonuc.ToString();

    }
    private void Parametre(int sayi1, int sayi2, int sayi3)
    {
        int sonuc = sayi1 + sayi2 + sayi3;
        text.text = sonuc.ToString();
        text.color = Color.red;
    }
    private void DefaultValueDeneme(int sayi1 = 10)
    {
        int sonuc = ++sayi1;
        text.text = sonuc.ToString();
    }
}
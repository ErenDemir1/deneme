using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class tekrar : MonoBehaviour
{
    List<string> deneme = new List<string>();
    [SerializeField] Text Text;
    [SerializeField] Text Money;
    [SerializeField] Text acýklama;

    int _Para = 100;
    int _ButonTik = 0;
    void Start()
    {
        Money.text = ($" {_Para} GOLD");

        deneme.Add("Sahin kalkan : 25 gold");
        deneme.Add("Kaplan kalkan : 50 gold");
        deneme.Add("Ejderha pulu kalkan : 150 gold");
        deneme.Add("Aslan agzý 10 gold");
        deneme.Add("Üç Ýmparator kalkaný");
        deneme.Add("Titan Kalkan");
    }
    public void Sahin()
    {
        Text.text = deneme[0]; 
        _ButonTik = 1;
    }
    public void Aslan()
    {
        Text.text = deneme[3]; 
        _ButonTik = 2;
    }
    public void Kaplan()
    {
        Text.text = deneme[1]; 
        _ButonTik = 3;
    }
    public void Ejder()
    {
        Text.text = deneme[2]; 
        _ButonTik = 4;
    }
    public void Buy()
    {
        switch (_ButonTik)
        {
            case 1:
                if (_Para >= 25)
                {
                    _Para = _Para - 25;
                    Money.text = ($" {_Para} GOLD");
                    acýklama.text = "Eþya satýn alýndý";
                }
                else
                {
                    acýklama.text = "FAKÝR OÇ";
                }

                break;
            case 2:
                if (_Para >= 10)
                {
                    _Para = _Para - 10;
                    Money.text = ($" {_Para} GOLD");
                    acýklama.text = "Eþya satýn alýndý";
                }
                else
                {
                    acýklama.text = "FAKÝR OÇ";
                }

                break;
            case 3:
                if (_Para >= 50)
                {
                    _Para = _Para - 50;
                    Money.text = ($" {_Para} GOLD");
                    acýklama.text = "Eþya satýn alýndý";
                }
                else
                {
                    acýklama.text = "FAKÝR OÇ";
                }

                break;
            case 4:
                if (_Para >= 150)
                {
                    _Para = _Para - 150;
                    Money.text = ($" {_Para} GOLD");
                    acýklama.text = "Eþya satýn alýndý";
                }
                else
                {
                    acýklama.text = "FAKÝR OÇ";
                }

                break;
            default:
                acýklama.text = "Eþya seçiniz";


                break;

        }
    }
}
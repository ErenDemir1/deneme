using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PanelUI : MonoBehaviour
{
    [SerializeField] Text localText;
    [SerializeField] Text globalText;

    long _sayi = 0;

    public void LocalArttir()
    {
        long sayi = 0;

        sayi++;
        localText.text = sayi.ToString();
    }
    public void GlobalArttir()
    {
        _sayi++;
        _sayi = _sayi + _sayi;

        globalText.text = _sayi.ToString();
    }

    
        
}

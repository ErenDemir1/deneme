using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Alistirmabir : MonoBehaviour
{
    [SerializeField] Text Sonuc;
    [SerializeField] Text InputField;

    public void BasAmk()


    {
        //int[] numbers = new int[20];

        //for (int i = 0; i < 20; i++)
        //{
        //    if ((i * 2) <= 20)
        //    {
        //        Debug.Log((i * 2) + "  Bu bir cift sayidir");

        //    }
        //    if ((i * 2)+1 < 20)
        //    {
        //        Debug.Log(((i * 2) + 1) + "  Bu bir tek sayidir)");
        //    }
            int a;
            a = Convert.ToInt32(InputField.text);
          
            if (a%2==0)
            {
            Sonuc.text = "Bu bir cift sayidir.";
            }
            else
            {
            Sonuc.text = "Bu bir tek sayidir";
            }
        

    }

   

	

}

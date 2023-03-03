using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class KoleksiyonYapi : MonoBehaviour
{
    
    void Start()
    {
        Diziler();
        ListDeneme();
        DictionaryDeneme();
        QueueDeneme();  





    }

    private void Diziler()
    {
        int[] numbers = new int[5] { 5, 10, 20, 30, 55 };

        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log(numbers[i]);
        }
    }
    private void ListDeneme()
    {
        List<int> numbers = new List<int>
        {
            5,
            10,
            20,
            55
        };

        Debug.Log(numbers[2]);

        for (int i = 0; i < numbers.Count; i++)
        {
            Debug.Log(numbers[i]);

        }
        foreach (int number in numbers)
        {
            Debug.Log(number);
        }
    }
    private void DictionaryDeneme()
    {
        Dictionary<int, string> ornekler1 = new Dictionary<int, string>();

        ornekler1.Add(1, "Sayi1");
        ornekler1.Add(2, "Sayi2");
        ornekler1.Add(3, "Sayi3");

        string value = ornekler1.FirstOrDefault(x => x.Key == 1).Value;


        Debug.Log(value);
    }
    private void QueueDeneme()
    {
        Queue<string> days = new Queue<string>();

        days.Enqueue("Pazartesi");
        days.Enqueue("Sali");
        days.Enqueue("Carsamba");

        for (int i = 0; i < 3; i++)

            Debug.Log(days.Dequeue());
    }
}

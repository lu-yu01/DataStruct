using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueTest : MonoBehaviour
{
    Queue<string> numbers = new Queue<string>();
    Queue<string> queueCopy = new Queue<string>();
    void Start()
    {
        numbers.Enqueue("one");
        numbers.Enqueue("two");
        numbers.Enqueue("three");
        numbers.Enqueue("four");
        numbers.Enqueue("five");

        foreach (string number in numbers)
        {
            Debug.Log("first==" + number);
        }

        numbers.Dequeue();
        foreach (string number in numbers)
        {
            Debug.Log("Second==" + number);
        }

        string peek =  numbers.Peek();
        Debug.Log("third peek==" + peek);
        string dequeue =  numbers.Dequeue();
        Debug.Log("four peek==" + peek);

        foreach (string number in numbers)
        {
            Debug.Log("Seventh==" + number);
        }
        Queue<string> queueCopy = new Queue<string>(numbers.ToArray());

        foreach (string number in queueCopy)
        {
            Debug.Log("Eighth queueCopy===" + number);
        }

        string[] array2 = new string[numbers.Count * 2];
        numbers.CopyTo(array2, numbers.Count);
        for (int i = 0; i < array2.Length; i++)
        {
            Debug.Log("array2==" + array2[i]);
        }

        Queue<string> queueCopy2 = new Queue<string>(array2);
        foreach (string number in queueCopy2)
        {
            Debug.Log("nine==" + number);
        }

        bool boolValue = queueCopy2.Contains("four");
        Debug.Log("contain_four:" + boolValue);
        queueCopy.Clear();
        Debug.Log("clear queuecopy:" + queueCopy.Count);
        Debug.Log("clear numbers:" + numbers.Count);
        foreach (string number in numbers)
        {
            Debug.Log("Tenth==" + number);
        }
    }
}

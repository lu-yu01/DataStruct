using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinarySearchingTest : MonoBehaviour
{
    int[] data = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 }; //有序数组
    void Start()
    {
       int index =  BinarySearchDisplay(data, 7, 0, data.Length-1);
        Debug.Log("index==" + index);
    }


    public int BinarySearchDisplay(int[] array,int numberToFind, int indexMin, int indexMax)
    {
        if (indexMin > indexMax)
        {
            return -1;
        }
        int mid = indexMin + ((indexMax - indexMin) / 2);
        if (array[mid] < numberToFind)
        {
            return BinarySearchDisplay(array, numberToFind, mid + 1, indexMax);
        }
        else if (numberToFind < array[mid])
        {
            return BinarySearchDisplay(array, numberToFind, indexMin, mid - 1);
        }
        else
        {
            return mid;
        }

    }



    public void ListBinarySearch()
    {

        List<string> dinosaurs = new List<string>();
        dinosaurs.Add("Pachycephalosaurus");
        dinosaurs.Add("Amargasaurus");
        dinosaurs.Add("Mamenchisaurus");
        dinosaurs.Add("Deinonychus");
        for (int i = 0; i < dinosaurs.Count; i++)
        {
            Debug.Log("Firstvalue==" + dinosaurs[i]);
        }
        int index = dinosaurs.BinarySearch("Amargasaurus");
        Debug.Log("index==" + index);
        if (index < 0)
        {
            // dinosaurs.BinarySearch()
        }
    }


}

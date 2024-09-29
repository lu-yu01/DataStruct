using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 插值搜索
/// </summary>
public class InterSearch : MonoBehaviour
{
    int[] datas = new int[] { 10, 14, 19, 26, 27, 31, 33, 35, 42, 44 };
    void Start()
    {
        int index = InterSearchTest(datas, 44);
        //int index = InterpolationSearch(datas, 0, datas.Length, 44);
        Debug.Log("index==" + index);
    }

    public int InterSearchTest(int[] array, int data)
    {
        int size = array.Length;
        int lo = 0;
        int mid = -1;
        int hi = array.Length - 1;
        int index = -1;
        int count = 0;

        while (lo <= hi)
        {
            mid = (lo + (((hi - lo) / (array[hi] - array[lo]))  * (data - array[lo])));
            count++;
            if (array[mid] == data)
            {
                index = mid;
                break;
            }
            else
            {
                if (array[mid] < data)
                {
                    lo = mid + 1;
                }
                else
                {
                    hi = mid - 1;
                }
            }
        }
        

        return index;
    }


    private int InterpolationSearch(int[] arr, int low, int height, int value)
    {
        if (arr == null || arr.Length == 0 || low >= height)
        {
            return -1;
        }
        int hi = height - 1;
        int lowValue = arr[low];
        int heightValue = arr[hi];
        if (lowValue > value || value > heightValue)
        {
            return -1;
        }
        int mid;
        while (low <= hi)
        {
            mid = low + ((value - lowValue) / (heightValue - lowValue)) * (hi - low);
            int item = arr[mid];
            if (item == value)
            {
                return mid;
            }
            else if (item > value)
            {
                hi = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        return -1;
    }

}

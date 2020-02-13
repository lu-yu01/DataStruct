using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DataStruct
{
    public class Fibonaccisequence : MonoBehaviour
    {

        //斐波那契数列的递归与迭代实现方法
        public int Fibonacci(int i)
        {
            if (i <= 0)
            {
                return 0;
            }
            if (i == 1 || i == 2)
            {
                return 1;
            }
            return Fibonacci(i - 2) + Fibonacci(i - 1);
        }


        private int i;
        private int temp0;
        private int temp1;
        private int temp2;
        int fib(int n)
        {

            if (n <= 2)
            {
                return n;
            }

            temp1 = 0;
            temp2 = 1;
            temp0 = 0;

            for (i = 2; i <= n; i++)
            {
                temp0 = temp1 + temp2;
                temp1 = temp2;
                temp2 = temp0;
            }
            return temp0;
        } 

        void Start()
        {
            for (int i = 0; i <= 10; i++)
            {
                int result = Fibonacci(i);
                Debug.Log("===fibonacci:" + result);
            }

            for (int i = 0; i <= 10; i++)
            {
                int fib1 = fib(i);
                Debug.Log("===fib1:" + fib1);
            }
           

        }

    }
}


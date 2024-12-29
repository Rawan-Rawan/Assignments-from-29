using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
    public class RecursionScript : MonoBehaviour
    {
        public int FibonacciRecursive(int n)
        {
            if (n < 0) return -1;
            else if (n == 0) return 0;
            else if (n == 1) return 1;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        public int FibonacciIterative(int n)
        {
            if (n < 0) return -1;
            else if (n == 0) return 0;
            else if (n == 1) return 1;

            int a = 0, b = 1, result = 0;
            for (int i = 2; i <= n; i++)
            {
                result = a + b;
                a = b;
                b = result;
            }
            return result;
        }
        void Start()
        {
            int result10Recursive = FibonacciRecursive(10);
            Debug.Log($"FibonacciRecursive(10) = {result10Recursive}");

            int result30Recursive = FibonacciRecursive(30);
            Debug.Log($"FibonacciRecursive(30) = {result30Recursive}");

            int result10Iterative = FibonacciIterative(10);
            Debug.Log($"FibonacciIterative(10) = {result10Iterative}");

            int result30Iterative = FibonacciIterative(30);
            Debug.Log($"FibonacciIterative(30) = {result30Iterative}");
        }
    }
}
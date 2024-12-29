using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
namespace Assignment29
{
    public static class Utilities
    {
        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            Debug.Log($"Total = {sum}");
            return sum;
        }
        public static string RepeatString(int count)
        {
            if (count <= 0) { Debug.Log("Invalid count"); return string.Empty; }
            string result = "";
            for (int i = count; i > 0; i--)
            {
                result += "Hello";
            }
            Debug.Log($"Repeated string: {result}");
            return result;
        }
    }
}
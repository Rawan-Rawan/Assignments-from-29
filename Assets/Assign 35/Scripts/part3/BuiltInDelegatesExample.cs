using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public class BuiltInDelegatesExample : MonoBehaviour
    {
        Action<string> logMessage;
        void Start()
        {
            logMessage = (message) => Debug.Log(message);
            logMessage("Hello from Action delegate!");

            Func<int, int> square = (number) => number * number;
            int result1 = square(5);
            Debug.Log($"Square: {result1}");

            Predicate<int> isEven = (number) => number % 2 == 0;
            bool result2 = isEven(4);
            Debug.Log($"Is 4 even? {result2}");
        }
    }
}
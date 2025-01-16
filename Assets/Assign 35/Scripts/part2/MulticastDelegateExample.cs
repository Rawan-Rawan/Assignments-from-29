using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public delegate void MathOperation(int number);
    public class MulticastDelegateExample : MonoBehaviour
    {
        void Start()
        {
            MathOperation operation = null;
            operation += DoubleNumber;
            operation += SquareNumber;
            operation += CubeNumber;

            int inputValue = 5;
            operation(inputValue);
        }
        void DoubleNumber(int number)
        {
            int doubleNumber = number * 2;
            Debug.Log($"Double:{doubleNumber}");
        }
        void SquareNumber(int number)
        {
            int squareNumber = number * number;
            Debug.Log($"Square:{squareNumber}");
        }
        void CubeNumber(int number)
        {
            int cubeNumber = number * number * number;
            Debug.Log($"Cube:{cubeNumber}");
        }
    }
}
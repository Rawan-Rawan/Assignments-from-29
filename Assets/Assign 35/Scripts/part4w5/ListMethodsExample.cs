using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public class NewBehaviourScript : MonoBehaviour
    {
        void Start()
        {
            List<int> numbers = new List<int> { 3, 1, 4, 1, 5, 9 };
            List<int> numbers2 = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6 };
            List<int> filteredNumbers = numbers2.FindAll(number => number % 2 == 0);


            numbers.Sort((int X, int Y) => Y.CompareTo(X));
            string result1 = string.Join(", ", numbers);
            Debug.Log(result1);

            string result2 = string.Join(", ", filteredNumbers);
            Debug.Log(result2);

        }

    }
}

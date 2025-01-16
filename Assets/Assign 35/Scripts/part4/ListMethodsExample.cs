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
            numbers.Sort((int X, int Y) => Y.CompareTo(X));
            string result = string.Join(", ", numbers);
            Debug.Log(result);
        }

    }
}

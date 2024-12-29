using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
namespace Assignment29
{
    public class TestPart3 : MonoBehaviour
    {
        void Start()
        {
            Utilities.Add(5, 8, 4, 6);
            Utilities.RepeatString(5);
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
namespace Assignment29
{
    public class BasicsScript : MonoBehaviour

    {
        void Start()
        {
            var integer = 5;
            var stringg = "subhi";
            var boolean = true;
            Debug.Log($"The Number {integer} is : {NumberType(integer)}");
            print(DateTime.Now.Date);
            print(DateTime.Now.TimeOfDay);
            print(DateTime.Now.Hour);
        }
        public string NumberType(int numberType)
        {
            return numberType % 2 == 0 ? "Even" : "Odd";
        }
    }
}

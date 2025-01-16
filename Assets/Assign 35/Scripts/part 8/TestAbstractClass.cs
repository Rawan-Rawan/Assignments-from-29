using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public class TestAbstractClass : MonoBehaviour
    {
        void Start()
        {
            DerivedClassExample derivedClass = new DerivedClassExample();
            derivedClass.PerformAction();
            derivedClass.PrintInfo();
        }
    }
}

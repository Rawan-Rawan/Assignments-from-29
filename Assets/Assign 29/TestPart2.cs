using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
    public class TestPart2 : MonoBehaviour
    {

        void Start()
        {
            CustomObject obj1 = new CustomObject(123, "Subhi");
            CustomObject obj2 = new CustomObject(321, "Subhia");
            print(obj1.ToString());
            print(obj2.ToString());
            //[Optional]
            print(obj1 == obj2);
            print(obj1 != obj2);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public class BoxingUnboxing : MonoBehaviour
    {
        void Start()
        {
            int health = 100;
            object boxedHealth = health;
            int unboxedHealth = (int)boxedHealth;
            unboxedHealth -= 20;

            Debug.Log($"The original int value: {health}");
            Debug.Log($"The boxed value: {boxedHealth}");
            Debug.Log($"Unboxed and modified value: {unboxedHealth}");
        }
    }
}
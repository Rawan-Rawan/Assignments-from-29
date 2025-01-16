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
        }

    }
}
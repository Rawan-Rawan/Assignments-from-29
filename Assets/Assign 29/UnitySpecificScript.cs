using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
    public class UnitySpecificScript : MonoBehaviour
    {
        public GameObject TargetObject;
        void OnEnable()
        {
            print("GameObject Enabled");
        }

        void OnDisable()
        {
            print("GameObject Disabled");
        }
        void Start()
        {
            print("Game started!");

            GameObject targetObject = GameObject.Find("TargetObject");
            if (targetObject != null)
            {
                print($"Found object by name: {targetObject.name}");
            }
            else
            {
                print("No TargetObject found.");
            }

            GameObject jokerObject = GameObject.FindGameObjectWithTag("Joker");
            if (jokerObject != null)
            {
                print($"Found object by tag: {jokerObject.name}");
            }
            else
            {
                print("No Joker object found.");
            }

            Light lightObject = GameObject.FindObjectOfType<Light>();
            if (lightObject != null)
            {
                print($"Found object of type Light: {lightObject.name}");
            }
            else
            {
                print("No Light object found.");
            }
        }
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                if (TargetObject != null)
                {
                    TargetObject.SetActive(false);
                    print("TargetObject deactivated!");
                    gameObject.SetActive(false);
                }
            }
        }
    }
}

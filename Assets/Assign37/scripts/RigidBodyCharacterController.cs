using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment37
{
    public class RigidBodyCharacterController : MonoBehaviour
    {
        Rigidbody rigidbody;
        Vector3 input;
        float characterSpeed = 4f;
        bool jump = false;
        void Start()
        {
            rigidbody = GetComponent<Rigidbody>();
            rigidbody.freezeRotation = true;
            rigidbody.mass = 3;
            rigidbody.drag = 0;
        }
        void Update()
        {
            input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
            input = input.normalized * characterSpeed;
            input.y = rigidbody.velocity.y;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                jump = true;
            }
        }
        void FixedUpdate()
        {
            if (jump)
            {
                rigidbody.AddForce((Vector3.up * 30), ForceMode.Impulse);
                jump = false;
            }
            else
            {
                rigidbody.velocity = input;
            }
        }

    }
}

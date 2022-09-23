using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectRB04 : MonoBehaviour
{
    Rigidbody rigidbody;
    Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        moveDirection = new Vector3(-2400, 0,0); // Don't change this!
        rigidbody = GetComponent<Rigidbody>();

        // Don't move this line or add any new values (such as coefficients)!
        rigidbody.AddForce(moveDirection, ForceMode.Force);
    }

    // Update is called once per frame
    void Update()
    {
    }
}

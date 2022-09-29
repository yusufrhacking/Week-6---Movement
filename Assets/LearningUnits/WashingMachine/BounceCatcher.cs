using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCatcher : MonoBehaviour
{
    Vector3 moveDirection;
    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        moveDirection = new Vector3(0, (float)-0.001,0);
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().AddForce(moveDirection, ForceMode.Force);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectRB02 : MonoBehaviour
{
    Rigidbody rigidbody;
    [SerializeField] Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        // Where does one find a rigidbody these days anyway?

	    //rigidbody = rigidbody;
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.AddForce(moveDirection, ForceMode.Force);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectRB01 : MonoBehaviour
{
    Rigidbody rigidbody;
    [SerializeField] Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody.AddForce(moveDirection, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
    }
}

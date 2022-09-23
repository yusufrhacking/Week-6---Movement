using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectRB : MonoBehaviour
{
    Rigidbody rigidbody;
    [SerializeField] Vector3 moveDirection; 
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.MovePosition(transform.position + moveDirection);
    }
}

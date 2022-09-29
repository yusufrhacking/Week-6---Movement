using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject01 : MonoBehaviour
{
    [SerializeField] Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {

    }
    

    // Update is called once per frame
    void Update()
    {
        //ADDED + MOVE DIRECTION; this is necessary so the transform position
        //updates each time with a new direction change
        transform.position = transform.position + moveDirection;
    }
}

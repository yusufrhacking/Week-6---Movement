using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject02 : MonoBehaviour
{
    [SerializeField] Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        //Added this script and the other one to the red block
        //Adding both scripts is important because the MoveObject script
        //provides the force for RB02's force application
    }
    

    // Update is called once per frame
    void Update()
    {
        //Added +moveDirection for the same reasons as Unit1
        transform.position = (transform.position + moveDirection);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject03 : MonoBehaviour
{
    [SerializeField] Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        //Balanced the masses of the the two objects so the forces worked
        //Dropped blue, increased red
    }
    

    // Update is called once per frame
    void Update()
    {
        //Added +moveDirection for same reasons as earlier;
        transform.position = transform.position + moveDirection;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject04 : MonoBehaviour
{
    [SerializeField] Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        //Set red cube weight to 2 and the blue cube weight to 0.05
        //These balanced weights allowed it to stay on
    }
    

    // Update is called once per frame
    void Update()
    {
        //Added + moveDirection for the same reasons as before
        transform.position = transform.position + moveDirection;
    }
}

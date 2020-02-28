using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables_Script : MonoBehaviour
{
    public Vector3 rotation_speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(rotation_speed);
    }
}

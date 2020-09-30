using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForces : MonoBehaviour
{

    public Rigidbody rbody;
    public float force = 30;

    // Start is called before the first frame update
    void Start()
    {
        rbody.AddForce(x: 0, y: force, z: 0);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}

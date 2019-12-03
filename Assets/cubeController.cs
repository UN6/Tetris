﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeController : MonoBehaviour
{
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -30)
        {
            Destroy(gameObject);
        }
        if(transform.position.z > 400)
        {   
            GetComponent<ParticleSystem>().Play();
            Destroy(gameObject,1.5f);
        }
    }
}

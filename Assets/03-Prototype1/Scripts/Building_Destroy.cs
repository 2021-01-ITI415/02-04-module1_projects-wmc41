﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building_Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter ( Collision coll)
    {
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.tag == "Laser")
        {
            Destroy(this.gameObject);
        }
    }
}

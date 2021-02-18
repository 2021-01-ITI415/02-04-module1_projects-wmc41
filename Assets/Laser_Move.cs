using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_Move : MonoBehaviour
{
    public float laserspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * laserspeed * Time.deltaTime;
    }
}

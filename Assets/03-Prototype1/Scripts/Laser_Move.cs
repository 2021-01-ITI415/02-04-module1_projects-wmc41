using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_Move : MonoBehaviour
{
    public float laserspeed;
    public float lifeDuration = 3f;
    public float lifeTimer;
    // Start is called before the first frame update
    void Start()
    {
        lifeTimer = lifeDuration;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * laserspeed * Time.deltaTime;
        lifeTimer -= Time.deltaTime;
        if (lifeTimer <= 0f)
        {
            Destroy(this.gameObject);
        }
    }
}

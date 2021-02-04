using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree_Movement : MonoBehaviour
{
    public GameObject applePrefab;

    public float speed = 1f;

    public float chancetochangedirection = 0.05f;

    public float rateappledrop = 1;

    public float leftandright = 20f;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("DropApple", 2f, rateappledrop); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if (pos.x < -leftandright)
        {
            speed = -speed;
        } else if (pos.x > leftandright)
        {
            speed = -speed;
        } else if (Random.value < chancetochangedirection)
        {
            speed = -speed;
        }

    }

    void DropApple()
    {
        GameObject apple = Instantiate(applePrefab);
        apple.transform.position = transform.position;
    }
}

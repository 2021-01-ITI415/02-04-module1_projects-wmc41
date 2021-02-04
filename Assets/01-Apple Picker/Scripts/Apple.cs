using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public static float bottomy = -20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y < bottomy)
        {
            Destroy(this.gameObject);

            ApplePicker1 apScript = Camera.main.GetComponent<ApplePicker1>();

            apScript.AppleDestroyed();
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public Camera MainCamera;
    public float speed;
    public float rotate_speed;
    public GameObject player;
    public GameObject laserPrefab;
    private Rigidbody rb;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float rotation = Input.GetAxis("Horizontal") * rotate_speed * Time.deltaTime;

        transform.Translate((translation * -1), 0, 0);
        transform.Rotate(0, rotation, 0);

        if (Input.GetMouseButtonDown(0))
        {
            GameObject laserObject = Instantiate(laserPrefab.gameObject);
            laserObject.transform.position += MainCamera.transform.position + MainCamera.transform.forward;
           
        }
    }
}

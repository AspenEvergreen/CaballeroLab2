using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5;
    private Rigidbody rb;
    private float zBound = 6;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // move with arrow keys
        float hi = Input.GetAxis("Horizontal");
        float vi = Input.GetAxis("Vertical");

        rb.AddForce(Vector3.forward * speed * vi);
        rb.AddForce(Vector3.right * speed * hi);


        //boundaries
        if (transform.position.z < -zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
        }

        if (transform.position.z > zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
        }
    }
}

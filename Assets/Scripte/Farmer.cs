using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farmer : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            Vector2 ve = Vector2.left * speed;
            rb.velocity = ve;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            Vector2 ve = Vector2.right * speed;
            rb.velocity = ve;
        }
    }
}

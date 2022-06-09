using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [Header("Component")]
    Rigidbody2D rb;
    [Header("Stat")]
    [SerializeField]
    float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        camera = GetComponent<Camera>();
    }

    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.fixedDeltaTime;
        float y = Input.GetAxisRaw("Vertical") * moveSpeed * Time.fixedDeltaTime;

        if (Input.GetKey(KeyCode.Space)) {
            y += y+10;
        }
        
        rb.velocity = new Vector3(x, y);
        rb.velocity.Normalize();
        GetComponent<Camera>().velocity = new Vector3(x, y);
        GetComponent<Camera>().velocity.Normalize();
        Debug.Log(rb.position);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}

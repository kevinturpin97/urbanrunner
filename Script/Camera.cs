using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [Header("Component")]
    Rigidbody2D rb;
    [Header("Stat")]
    [SerializeField]
    float moveSpeed;
    float x = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Move()
    {
        x += moveSpeed;
        rb.velocity = new Vector3(x * moveSpeed, 0);
        rb.velocity.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}

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
    float camSpeed = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Move()
    {

<<<<<<< HEAD
        if (Input.GetKey(KeyCode.Space)) {
            y += y+10;
        }
        
        rb.velocity = new Vector3(x, y);
        rb.velocity.Normalize();
        GetComponent<Camera>().velocity = new Vector3(x, y);
        GetComponent<Camera>().velocity.Normalize();
        Debug.Log(rb.position);
=======
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        gameObject.transform.position = new Vector2(transform.position.x + (h * moveSpeed),
           transform.position.y + (v * moveSpeed));
           Debug.Log(gameObject.transform.position[1]);
>>>>>>> 978a0a98858828afb6218277d0353e6bbf103d97
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}

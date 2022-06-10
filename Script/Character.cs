using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Character : MonoBehaviour
{
    public float jumpForce;
    public float moveSpeed;
    int score = 0;
    Rigidbody2D rb;
    bool isGrounded = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (isGrounded == true) {
                rb.AddForce(Vector2.up * jumpForce);
                isGrounded = false;
            }
        }

        if (Input.GetAxisRaw("Horizontal") != 0.0f) {
            transform.position = transform.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0.0f, 0.0f) * moveSpeed * Time.deltaTime;
        }
        
    }
    
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("ground")) {
            if (isGrounded == false) {
                isGrounded = true;
            }
        }
    }
    public TextMeshProUGUI textMesh;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("money")) {
            Destroy(other.gameObject);
            score++;
        }
        else if (other.gameObject.CompareTag("special")) {
            Destroy(other.gameObject);
            score += 10;
        }

        textMesh.text = "Score: " + score.ToString();
    }
}

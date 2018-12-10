using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    [SerializeField]
    float speed = 10f;
    [SerializeField]
    float height = 30f;

    float jump;

    bool isJump;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y + jump);

        if (Input.GetKeyDown("space") && isJump)
            jump += height;
        else
            jump = 0.0f;

        rb.position.Normalize();
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "ground")
        {
            Debug.Log("bisa");
            isJump = true;
        }
        
    }
    void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.tag=="ground")
            isJump = false;
        Debug.Log("gakbisa");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpPower;
    // 최초 한번
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // 매 프레임 마다 
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpPower; // (0,1)*3 = (0,3)
        }
    }
}

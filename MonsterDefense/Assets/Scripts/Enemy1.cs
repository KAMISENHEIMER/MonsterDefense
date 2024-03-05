using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    const int movingSpeed = 1;
    Rigidbody2D rb;
    // Start is called before the first frame update
    
    void Start()
    {
        rb = GetComponent <Rigidbody2D>();
        rb.velocity = new Vector2(movingSpeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

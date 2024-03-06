using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody2D rb;
    public float health;
    public float speed;

    Enemy(float health, float speed, float height){ // constructor
        this.health = health;
        this.speed = speed;
        gameObject.transform.position = new Vector2(10, height);
    }


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent <Rigidbody2D>();
        rb.velocity = new Vector2(speed, 0);
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        health --;
        if(health <= 0){
            Destroy(gameObject);
        }
    }
}

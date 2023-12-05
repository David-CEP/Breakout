using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public Rigidbody2D rb2d;
    void Start()
    { 
        rb2d.velocity = Vector2.down * 10f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Vector2 tempPos = rb2d.position;
        //tempPos.y *= -1;
        rb2d.velocity = Vector2.left * 10f;
        rb2d.velocity = Vector2.down * 10f;
        
        collision.gameObject.SetActive(false);
    }
}

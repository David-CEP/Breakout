using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    void Update()
    {
        Move();
    }
    private void Move()
    {
        Vector2 tempPos = gameObject.GetComponent<Rigidbody2D>().velocity;
        tempPos.x = Input.GetAxis("Horizontal") * 5f;
        gameObject.GetComponent<Rigidbody2D>().velocity = tempPos;
    }
}

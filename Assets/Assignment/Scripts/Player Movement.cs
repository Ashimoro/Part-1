using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector2 direction;
    float force = 200;
    Rigidbody2D rigibody;

    void Start()
    {
        rigibody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {
        rigibody.AddForce(direction * force * Time.deltaTime);
    }
}

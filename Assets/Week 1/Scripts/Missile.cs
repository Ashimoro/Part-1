using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public Vector2 speed = new Vector2(10,0);
    Rigidbody2D rigibody;
   
    private void Start()
    {
        rigibody = GetComponent<Rigidbody2D>();
        

    }

    void Update()
    {
       // transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    private void FixedUpdate()
    {
        rigibody.MovePosition(rigibody.position + speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

}

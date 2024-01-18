using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
      
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger from: " + collision.gameObject);
        spriteRenderer.color = Color.red;
        gameObject.SetActive(false);
        spriteRenderer.enabled = false;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
       spriteRenderer.color = Color.blue;
    }
}

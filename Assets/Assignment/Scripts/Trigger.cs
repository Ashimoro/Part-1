using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject arrow1;
    public GameObject arrow2;
    public GameObject gate;

    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        arrow1.SetActive(false);
        arrow2.SetActive(true);
        gate.SetActive(false);
    }
    void Update()
    {
        
    }
}

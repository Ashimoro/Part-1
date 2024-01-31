using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leverscript : MonoBehaviour
{
    public GameObject gate;
    public GameObject arrow;
    public GameObject lever;
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gate.SetActive(false);
        arrow.SetActive(false);
        lever.transform.Rotate(0, 0, -80);
    }
    void Update()
    {
        
    }
}

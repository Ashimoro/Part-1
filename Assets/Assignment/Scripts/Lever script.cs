using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leverscript : MonoBehaviour
{
    public GameObject gate;
    public GameObject lever;
    public GameObject prefab_arrow;
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gate.SetActive(false);
        GameObject.Destroy(prefab_arrow);
        lever.transform.Rotate(0, 0, -80);
        
    }
    void Update()
    {
        
    }
}

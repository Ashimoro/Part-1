using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject launcher;
    public Transform laucherTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Launch");
        GameObject newObject = Instantiate(launcher, laucherTransform.position, laucherTransform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

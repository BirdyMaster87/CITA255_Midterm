using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropperScript : MonoBehaviour
{
    public GameObject spherePrefab;
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            DropSphere();
        }
    }

    void DropSphere() 
    {
        GameObject newSphere = Instantiate(spherePrefab);
        newSphere.transform.position = transform.position;

        newSphere.transform.position = new Vector3(transform.position.x, transform.position.y - 10f, transform.position.z);
    }
}

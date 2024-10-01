using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        Speed = -5f;
    }

    // Update is called once per frame
    void Update()
    {
        //get the current position of the bomber
        Vector3 dropperPos = transform.position;

        //change the vector position
        dropperPos.x += Speed * Time.deltaTime;

        transform.position = dropperPos;
    }
}

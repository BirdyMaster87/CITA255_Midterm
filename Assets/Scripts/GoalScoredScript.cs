using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScoredScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Gold")
        {
            GameManager.instance.number += 4;
        }
        else if(other.tag == "Silver")
        {
            GameManager.instance.number += 2;
        }
        else if(other.tag == "Bronze")
        {
            GameManager.instance.number++;
        }

        Destroy(gameObject);
    }
}

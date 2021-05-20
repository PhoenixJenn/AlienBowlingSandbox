using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingResetLever : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hand"))
        {
            Debug.Log("Reset Game!");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hand") {
            Debug.Log("Reset Game 1!");
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingResetLever : MonoBehaviour
{
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Hand"))
    //    {
    //        Debug.Log("Reset Game!");
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        // note, calls this repeatedly when you grab the trigger
        if (other.tag == "Hand") {
            Debug.Log("Reset Bowling!");
            //myObject.GetComponent<MyScript>().MyFunction();
            this.GetComponent<BowlingGameManager>().ResetGame();
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kegel : MonoBehaviour
{
    //private Vector3 startPosition;
    //private Quaternion startRotation;
    // Start is called before the first frame update
    void Start()
    {
        //startPosition = this.transform.position;
        //startRotation = this.transform.rotation;
    }

    // if fall down, add to score ?
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ball"))
        {
            Debug.Log("hit: " + this.name);
            //other.gameObject.SetActive(false);
            //count++;
            //SetCountText();

            // Debug.Log(other.gameObject.name);
            // Debug.Log(count);
        }

    }
}

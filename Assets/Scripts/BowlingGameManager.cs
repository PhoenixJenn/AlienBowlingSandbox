using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingGameManager : MonoBehaviour
{

    // public Button button;//reference to reset button; want to add an event listener to button press
    //Attach Button from the Editor
    //public Button resetButton;
    public GameObject[] pinSet;

    private Dictionary<GameObject, Transform> pinLocations;
    private Vector3[] defaultPos;
    private Vector3[] defaultScale;
    private Quaternion[] defaultRot;
    private Transform[] pins;
    void Start()
    {
       StorePinLocations();
        
    }

    private void StorePinLocations() {
        //Create pos, scale and rot, Transform array size based on sixe of Objects found
        defaultPos = new Vector3[pinSet.Length];
        defaultScale = new Vector3[pinSet.Length];
        defaultRot = new Quaternion[pinSet.Length];
        pins = new Transform[pinSet.Length];

       
        // get positions of all bowling pins
        foreach (GameObject pin in pinSet)
        {
          //  pinLocations.Add(pin, pin.transform);
            Debug.Log(pin.name + ":" + pin.transform.position);
          //  pin.transform.position = pinLocations[pin].position;
        }
        //Get original the pos, scale and rot of each Object on the transform

        for (int i = 0; i < pinSet.Length; i++)
        {
           // pins[i] = pinSet[i].GetComponent<Transform>();
            // find the Vector3 of the Gameobject
            defaultPos[i] = pinSet[i].transform.position;
            defaultScale[i] = pinSet[i].transform.localScale;
            defaultRot[i] = pinSet[i].transform.rotation;
        }
    }


    void ResetGame()
    {
        // put  all pins back in their original postion
        // ButtonInstance.onClick.AddListener(() => ResetGame());
        //Restore the all the original pos, scale and rot  of each GameOBject
        for (int i = 0; i < pinSet.Length; i++)
        {
            pinSet[i].transform.position = defaultPos[i];
            pinSet[i].transform.localScale = defaultScale[i];
            pinSet[i].transform.rotation = defaultRot[i];
        }
    }
       

}

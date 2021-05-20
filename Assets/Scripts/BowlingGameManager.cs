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
    //private Vector3[] defaultScale;
    private Quaternion[] defaultRot;
    private Quaternion startingRotation = new Quaternion(0, 0, 0, 1);
    private Transform[] pins;
    private bool gameOver = true;
    void Start()
    {
       StorePinLocations();
        
    }

    private void StorePinLocations() {
        //Create pos, scale and rot, Transform array size based on sixe of Objects found
        // defaultScale = new Vector3[pinSet.Length];

        defaultPos = new Vector3[pinSet.Length];
        defaultRot = new Quaternion[pinSet.Length];
        pins = new Transform[pinSet.Length];

       
        // get positions of all bowling pins
        foreach (GameObject pin in pinSet)
        {
          //  pinLocations.Add(pin, pin.transform);
            Debug.Log(pin.name + ":" + pin.transform.localPosition);
          //  pin.transform.position = pinLocations[pin].position;
        }
        //Get original the pos, scale and rot of each Object on the transform

        for (int i = 0; i < pinSet.Length; i++)
        {
           // pins[i] = pinSet[i].GetComponent<Transform>();
            // find the Vector3 of the Gameobject
            defaultPos[i] = pinSet[i].transform.localPosition; // can also use position.x, position.y, position.z
            //defaultScale[i] = pinSet[i].transform.localScale;
            defaultRot[i] = pinSet[i].transform.rotation;
        }
    }


    public void ResetGame()
    {
        // put  all pins back in their original postion
        // ButtonInstance.onClick.AddListener(() => ResetGame());
        //Restore the all the original pos, scale and rot  of each GameOBject
        if (gameOver == true) {
            GameObject ball;
            ball = GameObject.Find("BowlingBall3");

            Vector3 tempVector3 = new Vector3(-0.152f, 0, -.117f);

            for (int i = 0; i < pinSet.Length; i++)
            {
                pinSet[i].SetActive(false);
                //Debug.Log("Reset " + pinSet[i].gameObject.name + " at " + defaultPos[i]);
                pinSet[i].transform.position = tempVector3;

                // pinSet[i].transform.localScale = defaultScale[i];
                //pinSet[i].transform.rotation = defaultRot[i];
            }
            for (int i = 0; i < pinSet.Length; i++)
            {
                pinSet[i].SetActive(true);

                //Debug.Log("Reset " + pinSet[i].gameObject.name + " at " + defaultPos[i]);
                Debug.Log("Reset " + pinSet[i].gameObject.name + " at " + defaultRot[i]);
                if (i == 1) {   
                    // ball.transform.localPosition = defaultPos[i];
                   // Debug.Log("Reset " + pinSet[i].gameObject.name + " at " + defaultPos[i]);
                    pinSet[i].transform.position = tempVector3;
                } else
                {
                    pinSet[i].transform.position = defaultPos[i]; // this works but puts int in the wrong place
                                                                  // pinSet[i].transform.rotation = defaultRot[i];
                    pinSet[i].transform.rotation = startingRotation;
                }

               
                //pinSet[i].SetActive(true);


                // pinSet[i].transform.localScale = defaultScale[i];

            }
            gameOver = false;
        }
       
    }
       

}

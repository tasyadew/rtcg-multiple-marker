using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class rock : MonoBehaviour
{
    //public GameObject uiObject;
    void Start()
    {

    }

    private void OnTriggerEnter(Collider collision)
    {
        // Check if collision occurred with the desired object
        if (collision.tag == "Paper")
        {
            print("collided rock-paper from rock script");
            collision.gameObject.GetComponent<showUI>().displayPaperWin();

        }
        else if (collision.tag == "Scissor")
        {
            print("collided rock-scissor from rock script");
            collision.gameObject.GetComponent<showUI>().displayRockWin();

        }
    }
}

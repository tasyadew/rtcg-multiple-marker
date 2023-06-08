using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class paper : MonoBehaviour
{


    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider collision)
    {
        // Check if collision occurred with the desired object
        if (collision.tag == "Scissor")
        {
            print("collided scissor-paper from paper script");
            collision.gameObject.GetComponent<showUI>().displayScissorWin();

        }
    }

}

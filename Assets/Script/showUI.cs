using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showUI : MonoBehaviour
{
    public GameObject rockWinText;
    public GameObject paperWinText;
    public GameObject scissorWinText;

    void Start()
    {
        rockWinText.SetActive(false);
        paperWinText.SetActive(false);
        scissorWinText.SetActive(false);
    }

    public void displayPaperWin()
    {
        print("paper wins");
        paperWinText.SetActive(true);
        StartCoroutine("WaitForSec");
    }

    public void displayScissorWin()
    {
        print("scissor wins");
        scissorWinText.SetActive(true);
        StartCoroutine("WaitForSec");
    }

    public void displayRockWin()
    {
        print("rock wins");
        rockWinText.SetActive(true);
        StartCoroutine("WaitForSec");
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(5);
        rockWinText.SetActive(false);
        paperWinText.SetActive(false);
        scissorWinText.SetActive(false);
    }
}

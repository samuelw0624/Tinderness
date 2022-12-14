using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionManager : MonoBehaviour
{
    public GameObject startScreen;
    public GameObject selectionScreen;
    public bool greenGood;
    public bool redGood;
    // Start is called before the first frame update

    public void StartOff()
    {
        startScreen.SetActive(false);
        selectionScreen.SetActive(true);
    }

    public void SelectionOff()
    {
        selectionScreen.SetActive(false);
    }

    public void SelectGreenM()
    {
        SelectionOff();
        greenGood = true;
        redGood = false; 
    }

    public void SelectRedM()
    {
        SelectionOff();
        redGood = true;
        greenGood = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionManager : MonoBehaviour
{
    public GameObject StartScreen;
    public GameObject SelectionScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartOff()
    {
        StartScreen.SetActive(false);
        SelectionScreen.SetActive(true);
    }

    public void SelectionOff()
    {
        SelectionScreen.SetActive(false);
    }

    public void SelectGreenM()
    {
        SelectionOff();
    }

    public void SelectRedM()
    {
        SelectionOff();
    }
}

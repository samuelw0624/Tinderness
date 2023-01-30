using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }
    public bool greenSteak;
    public bool redSteak;

    public int score;
    public int startScore = 0;
    public int currentScore;

    public TMP_Text scoreText;

    public GameObject goodEnd;
    public GameObject badEnd;
    // Start is called before the first frame update
    private void Awake()
    {
        //chooseGreen = DialogueLua.GetVariable("greenMeat").asBool;
        //chooseRed = DialogueLua.GetVariable("redMeat").asBool;
    }
    void Start()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);

        score = startScore;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
        greenSteak = DialogueLua.GetVariable("greenMeat").asBool;
        redSteak = DialogueLua.GetVariable("redMeat").asBool;
        //Debug.Log(chooseGreen);
        Debug.Log(score);

        if (score >= 20 && greenSteak)
        {
            badEnd.SetActive(true);
        }else if(score >= 20 && redSteak)
        {
            goodEnd.SetActive(true);
        }
    }
}

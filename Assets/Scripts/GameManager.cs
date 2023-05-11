using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public string gameState;
    public GameObject startScreen, endScreen, instructionScreen, reftoPlay, reftoBack, reftoAttack, reftoPlayAgain, reftoInstructions;
    public float score; 
    // Start is called before the first frame update
    void Start()
    {
        gameState = "titlescreen";
        startScreen.SetActive(true);
        endScreen.SetActive(false);
        instructionScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameState == "playable")
        {
            print("kablamm");
        }
    }

    public void PlayButton()
    {
        print("clicked");
        startScreen.SetActive(false);
        endScreen.SetActive(false);
        instructionScreen.SetActive(false);
        gameState = "playable";
    }

    public void InstructionButton()
    {
        print("clickedddd");
        startScreen.SetActive(false);
        endScreen.SetActive(false);
        instructionScreen.SetActive(true);
    }

    public void BackButton()
    {
        startScreen.SetActive(true);
        endScreen.SetActive(false);
        instructionScreen.SetActive(false);
    }

    public void PlayAgainButton()
    {
        startScreen.SetActive(false);
        endScreen.SetActive(false);
        instructionScreen.SetActive(false);
        SceneManager.LoadScene("SampleScene");
    }

    //play again and back button, play again completely reload scene
}

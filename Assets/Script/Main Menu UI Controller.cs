using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Button playButton;
    public Button exitButton;

    private void Start() 
    {
        playButton.onClick.AddListener(PlayGame);
        exitButton.onClick.AddListener(ExitGame);
    }

    private void PlayGame() 
    {
        SceneManager.LoadScene("Pinball Game");
    }

    private void ExitGame() 
    {
        Application.Quit();
    }
}

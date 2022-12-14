using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void EnterMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void GoToSettings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void GoToHighScores()
    {
        SceneManager.LoadScene("HighScores");
    }

    public void StartGame()
    {//starts practice mode scene
        SceneManager.LoadScene("GameScene");
    }
    public void doExitGame()
    {//quits game
        // TODO: save any game data here
     #if UNITY_EDITOR
         // Application.Quit() does not work in the editor so
         // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
         UnityEditor.EditorApplication.isPlaying = false;
     #else
         Application.Quit();
     #endif
    }
}

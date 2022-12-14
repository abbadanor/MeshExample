using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectDifficulty : MonoBehaviour
{
    // Update is called once per frame

    public static int difficulty;

    public Button Easy;
    public Button Medium;
    public Button Hard;

    public void SelectEasyDifficulty()
    {
        difficulty = 0;
    }

    public void SelectMediumDifficulty()
    {
        difficulty = 1;
    }
    public void SelectHardDifficulty()
    {
        difficulty = 2;
    }


    void Update()
    {
        switch (difficulty)
        {
            case 0:
                Easy.Select();
                break;
            case 1:
                Medium.Select();
                break;
            default:
                Hard.Select();
                break;
        }
    }
}

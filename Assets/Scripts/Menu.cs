using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public static int difficulty;
    public static bool multiplayer;
    public GameObject difficultyObj, multiplayerObj;

    public void SetDifficulty(int diff)
    {
        difficulty = diff;
    }
    public void SetMulti(bool multi)
    {
        multiplayer = multi;
    }
    public void Swap()
    {
        multiplayerObj.SetActive(!multiplayerObj.activeSelf);
        difficultyObj.SetActive(!difficultyObj.activeSelf);
    }
}

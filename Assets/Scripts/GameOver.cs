using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void PlayAgainButton()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void MainMenuButton()
    {
        SceneManager.LoadSceneAsync(0);
    }
}

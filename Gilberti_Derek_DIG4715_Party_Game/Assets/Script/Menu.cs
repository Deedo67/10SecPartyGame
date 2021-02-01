using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("GameScene");
    }

    public void HowGame()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Quit");
    }

    public void HowBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void GameBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void LoseBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }

    public void LoseRe()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void Win()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }
}

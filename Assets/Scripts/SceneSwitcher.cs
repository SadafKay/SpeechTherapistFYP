using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour

{
    
    public void startIdentification()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void startProblemLevelIdentification()
    {
        SceneManager.LoadScene(16);
    }
    public void animals()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 24);
    }
    public void ktoc()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 19);
    }
    public void ctok()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 19);
    }
    public void PlayAgain()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void NextLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void moveToNext()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void startPLI()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6);
    }
    public void backPLI()
    {
        SceneManager.LoadScene(21);
    }
    public void startGaming()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
    }
    public void backGaming()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }
    public void startLearning()
    {
        SceneManager.LoadScene(0);
    }
    public void backLearning()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 22);
    }

    public void startRec()
    {
        SceneManager.LoadScene(22);
    }

    public void moveTwoNext()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void moveTwoBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void startNumbersCategory()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }

    public void startAnimalsCategory()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }

    public void goBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void quitCategory()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex * 0 + 1);
    }
}

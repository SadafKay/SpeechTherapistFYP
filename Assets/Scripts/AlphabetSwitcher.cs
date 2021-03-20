using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AlphabetSwitcher : MonoBehaviour
{

    void Start()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}

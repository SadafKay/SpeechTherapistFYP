using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{

    int score = 0;
    [SerializeField] TextMeshProUGUI scoreText;

    public GameObject idCompleteUI;

    public void UpdateScore()
    {
        score = score + 1;
        scoreText.text = score.ToString();
        if(score == 3)
        {
            Time.timeScale = 0f;
            idCompleteUI.SetActive(true);
        }

    }
}

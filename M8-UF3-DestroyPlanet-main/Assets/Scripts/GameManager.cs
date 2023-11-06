using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int lives = 3;
    public int score = 0;

    public TMP_Text lbl_Score;
    public TMP_Text lbl_Lives;
    public Canvas FinalScreen; // Referencia al objeto del Canvas "FinalScreen"
    public Canvas Menu;

    // Start is called before the first frame update
    void Start()
    {
        UpdateUI();
        HideFinalScreen(); // Oculta el Canvas "FinalScreen" al inicio.
    }

    void HideFinalScreen()
    {
        FinalScreen.enabled = false;
    }

    // Función para actualizar la interfaz de usuario.
    void UpdateUI()
    {
        lbl_Score.text = "Score: " + score;
        lbl_Lives.text = "Lives: " + lives;
    }

    public void AddScore()
    {
        score++;
        UpdateUI();
    }

    public void TakeDamage()
    {
        lives--;
        UpdateUI();

        if (lives <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        PlayerPrefs.SetInt("HighScore", score);

        Time.timeScale = 0; // Detiene el tiempo del juego.
        FinalScreen.enabled = true; // Muestra el Canvas "FinalScreen".

        FinalScreen.GetComponent<FinalScreen>().ShowFinalScore(score);
    }

    public void ReturnToMenu()
    {
        // Oculta el Canvas de la pantalla final.
        FinalScreen.enabled = false;

        // Activa el Canvas del menú inicial.
        Menu.enabled = true;
    }

}

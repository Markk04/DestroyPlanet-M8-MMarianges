using UnityEngine.UI;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalScreen : MonoBehaviour
{
    public GameManager gameManager; // Asigna el objeto GameManager desde el Inspector.
    public Canvas HUD; // Asigna el objeto HUD desde el Inspector.
    public TextMeshProUGUI FinalScoreTxt;
    public Canvas Menu;
    public Button ReturnBtn;

    void Start()
    {
        // Oculta el HUD.
        HUD.enabled = false;

        ReturnBtn.onClick.AddListener(ReturnToMenu);
        
    }
    public void ShowFinalScore(int finalScore)
    {
        FinalScoreTxt.text = "Final Score: " + finalScore;
    }
    public void ReturnToMenu()
    {
        // Desactiva la FinalScreen.
        gameObject.SetActive(false);

        // Activa el Canvas del menú principal.
        Menu.enabled = true;
    }
}

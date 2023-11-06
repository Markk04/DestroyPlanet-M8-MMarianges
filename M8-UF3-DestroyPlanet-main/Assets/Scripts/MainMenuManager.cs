using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    public Canvas Menu;
    public Canvas HUD;
    public SpawnManager SpawnManager;

    public Button PlayBtn; // Asigna el botón "Play" en el Inspector.

    void Start()
    {
        Menu.enabled = true;
        HUD.enabled = false;
        SpawnManager.enabled = false; // Deshabilita el SpawnManager al inicio.

        PlayBtn.onClick.AddListener(StartGame);
    }

    void StartGame()
    {
        Menu.enabled = false;
        HUD.enabled = true;

        // Habilita el SpawnManager cuando se hace clic en "Play".
        SpawnManager.enabled = true;

    }
}

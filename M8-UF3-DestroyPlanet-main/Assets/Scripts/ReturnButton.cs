using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReturnToMainMenu : MonoBehaviour
{
    public Canvas Menu; // Asigna el objeto Canvas del menú inicial desde el Inspector.
    public Canvas FinalScreen; // Asigna el objeto Canvas de la pantalla final desde el Inspector.

    public void ReturnToMenu()
    {
        // Oculta la pantalla final.
        FinalScreen.enabled = false;    

        // Activa el menú inicial.
        Menu.enabled = true;
    }
}

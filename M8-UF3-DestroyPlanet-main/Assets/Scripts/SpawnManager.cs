using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject bombParent;
    public float respawnTime = 3.0f;
    private float timer = 0.0f;
    public GameObject prefabBomb;
    private bool isGameActive = false; // Controla si el juego está activo.

    // Start is called before the first frame update
    void Start()
    {
        StartGame(); // Inicia el juego al comienzo.
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameActive)
        {
            timer += Time.deltaTime;
            if (timer > respawnTime)
            {
                timer = 0.0f;
                CreateNewBomb();
            }
        }
    }

    private void CreateNewBomb()
    {
        Vector3 randPosition = Random.onUnitSphere * 0.5f;
        GameObject.Instantiate(prefabBomb, randPosition, Quaternion.identity, bombParent.transform);
    }

    // Método para iniciar el juego.
    public void StartGame()
    {
        // Reinicia el tiempo y comienza a generar bombas.
        timer = 0.0f;
        isGameActive = true;
    }

    // Método para reiniciar el juego.
    public void ResetGame()
    {
        // Detiene la generación de bombas.
        isGameActive = false;

        // Elimina todas las bombas existentes.
        foreach (Transform child in bombParent.transform)
        {
            Destroy(child.gameObject);
        }

        // Reinicia el tiempo.
        timer = 0.0f;

        // Inicia el juego nuevamente.
        StartGame();
    }
}

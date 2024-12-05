using UnityEngine;
using UnityEngine.SceneManagement;  // Necess�rio para gerenciar cenas

public class SceneChanger : MonoBehaviour
{
    // Nome da cena para a qual o jogador ser� transferido
    public string sceneToLoad = "game";  // Substitua com o nome da sua cena

    void Update()
    {
        // Detecta se a tecla "Space" foi pressionada
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Muda para a cena
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
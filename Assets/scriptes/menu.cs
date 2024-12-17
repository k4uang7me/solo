using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Jogo");
    }

    public void Voltar()
    {
        SceneManager.LoadScene("Menu");
    }

    public void sim()
    {
        SceneManager.LoadScene("sim");
    }

    public void nao()
    {
        SceneManager.LoadScene("nao");
    }

    public void sim2()
    {
        SceneManager.LoadScene("sim2");
    }

    public void nao2()
    {
        SceneManager.LoadScene("nao2");
    }

    public void VoltarFase2()
    {
        SceneManager.LoadScene("Abismo");
    }
}
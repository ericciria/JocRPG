using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public void Pantallas()
    {
        SceneManager.LoadScene("Seleccio");
    }
    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }
    public void Opcions()
    {
        SceneManager.LoadScene("Opcions");
    }
    public void Sortir()
    {
        Application.Quit();
    }

    public void Level1()
    {
        SceneManager.LoadScene("casaFora");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Pantalla2");
    }
    public void Level3()
    {
        SceneManager.LoadScene("Pantalla3");
    }

    public void LoadNextScene()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        if (index == 4)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(index + 1);
        }
    }

    public void ReloadScene()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index);
    }
    /*
    public void Continuar()
    {
        if (MenuM.activeSelf)
        {
            MenuM.SetActive(false);
            Time.timeScale = 1.0f;
        }
    }
    */
}

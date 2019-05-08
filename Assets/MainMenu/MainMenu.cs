using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene(2); //diisi "nama level", (build index/ nomor) 1, SceneManager.GetActiveScene().buildIndex + 1
    }

    public void LoadButton()
    {

    }

    public void OptionButton()
    {

    }

    public void ExitButton()
    {
        Application.Quit();
    }
}

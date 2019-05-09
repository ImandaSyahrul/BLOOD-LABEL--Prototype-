﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	GameObject panel;

    public void PlayButton()
    {
		panel = GameObject.Find("FadeOut");
		StartCoroutine(fading());
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //diisi "nama level", (build index/ nomor) 1, SceneManager.GetActiveScene().buildIndex + 1
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

	IEnumerator fading()
	{
		yield return new WaitForSeconds(2);
	}
}

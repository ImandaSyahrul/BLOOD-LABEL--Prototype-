﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
	public GameObject pauseMenuUI;
	public static bool gameIsPaused = false;

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (gameIsPaused)
			{
				Resume();
			}
			else
			{
				Pause();
			}
		}
        
    }

	void Pause()
	{
		pauseMenuUI.SetActive(true);
		Time.timeScale = 0f;
		gameIsPaused = true;
	}

	void Resume()
	{
		pauseMenuUI.SetActive(false);
		Time.timeScale = 1f;
		gameIsPaused = false;
	}
}

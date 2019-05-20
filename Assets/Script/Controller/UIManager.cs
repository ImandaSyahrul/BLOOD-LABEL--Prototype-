using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
	public GameObject panelHUD;
	public GameObject pausePanel;
	public static bool gameIsPaused;
	// Start is called before the first frame update
	void Start()
    {
		pausePanel.SetActive(false);
		panelHUD.SetActive(true);
		gameIsPaused = false;
    }

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

	public void Pause()
	{
		pausePanel.SetActive(true);
		Time.timeScale = 0f;
		gameIsPaused = true;
		panelHUD.SetActive(false);
	}

	public void Resume()
	{
		pausePanel.SetActive(false);
		Time.timeScale = 1f;
		gameIsPaused = false;
		panelHUD.SetActive(true);
	}

	public void ExitToMainmenu()
	{
		Resume();
		SceneManager.LoadScene(1);
	}
}

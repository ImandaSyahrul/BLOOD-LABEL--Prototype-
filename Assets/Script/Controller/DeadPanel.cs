using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadPanel : MonoBehaviour
{
	// Start is called before the first frame update
	public void MainMenuButton()
	{
		
		SceneManager.LoadScene(1); //diisi "nama level", (build index/ nomor) 1, SceneManager.GetActiveScene().buildIndex + 1
	}

	public void RetryButton()
	{
	
		SceneManager.LoadScene(3); //diisi "nama level", (build index/ nomor) 1, SceneManager.GetActiveScene().buildIndex + 1
	}
}

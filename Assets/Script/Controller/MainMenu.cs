using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public GameObject option;
	public GameObject fade;
	public GameObject loadgame;
	public Animator fadeAnim;

	//public Animator anim;

	private void Start()
	{
		//fade = GameObject.Find("FadePanel");
		//option = GameObject.Find("OptionPanel");
		//loadgame = GameObject.Find("LoadGamePanel");
		option.SetActive(false);
		loadgame.SetActive(false);
		fadeAnim=fade.GetComponent<Animator>();
	}

	public void PlayButton()
    {
		//fade.SetActive(true);
		//fadeAnim.Play("FadeIn");
		//System.Threading.Thread.Sleep(3000);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //diisi "nama level", (build index/ nomor) 1, SceneManager.GetActiveScene().buildIndex + 1
    }

    public void LoadButton()
    {
		loadgame.SetActive(true);
	}

    public void OptionButton()
    {
		option.SetActive(true);
    }

    public void ExitButton()
    {
        Application.Quit();
    }


	
}

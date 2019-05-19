using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGameMenu : MonoBehaviour
{
	GameObject panel;


	// Start is called before the first frame update
	void Start()
	{
		panel = this.gameObject; //Used for back button

	}

	
	// Update is called once per frame
	void Update()
	{

	}

	public void BackButton()
	{
		panel.SetActive(false);
	}
}

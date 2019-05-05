using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class videoskipper : MonoBehaviour
{
	// Assigns a movie texture to the current object. It starts playing
	// automatically and stops when the space bar is pressed.

	MovieTexture movTexture;

	void Start()
	{
		GetComponent<Renderer>().material.mainTexture = movTexture;
		movTexture.Play();
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			movTexture.Stop();
		}
	}
}

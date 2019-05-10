using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionMenu : MonoBehaviour
{
	GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
		panel = this.gameObject;
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

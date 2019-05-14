using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interact : MonoBehaviour
{
    private int i = 0;
	void OnTriggerStay2D(Collider2D other)
	{
		if (other.gameObject.name == "Player")
		{
			if (Input.GetKeyDown(KeyCode.Space)) //tombol yang ditekan untuk interact, sekarang spasi dulu
			{
				Debug.Log("You're Interacting!"+i);
                i++;
			}
		}
	}
}

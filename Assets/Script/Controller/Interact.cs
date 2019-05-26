using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interact : MonoBehaviour
{
	void OnTriggerStay2D(Collider2D other)
	{
		if (other.gameObject.name == "TriggerPlayer")
		{
			if (Input.GetKeyDown(KeyCode.Space)) //tombol yang ditekan untuk interact, sekarang spasi dulu
			{
				Debug.Log("You're Interacting!");
				Fungus.Flowchart.BroadcastFungusMessage("hello world first");
			}
		}
	}
}

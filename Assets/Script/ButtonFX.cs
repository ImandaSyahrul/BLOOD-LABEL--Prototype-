using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFX : MonoBehaviour
{
	public AudioSource myFx;
	public AudioClip hoverFx;
	public AudioClip clickFx;
    // when the mouse pointer is on the button
    public void HoverSound()
    {
		myFx.PlayOneShot(hoverFx);
    }

    // When clicking the button
    public void ClickSound()
    {
		myFx.PlayOneShot(clickFx);
    }

}

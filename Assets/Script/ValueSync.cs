using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ValueSync : MonoBehaviour
{
	public InputField inputField;
	public Slider slider;
	bool mutex = false;

	public void plusButton()
	{
		slider.value = slider.value + 1;
	}

	public void minusButton()
	{
		slider.value = slider.value - 1;
	}

	public void sliderToInputField()
	{
		if (!mutex)
		{
			mutex = true;
			inputField.text = ((int)slider.value).ToString();
			mutex = false;
		}
	}

	public void inputFieldToSlider()
	{
		if (!mutex)
		{
			mutex = true;
			string textValue = inputField.text;
			if (textValue.Length == 0) textValue = "0";
			int intValue = Int32.Parse(textValue);
			if (intValue < 0) intValue = 0;
			if (intValue > 100) intValue = 100;
			slider.value = intValue;
			inputField.text = intValue.ToString();
			mutex = false;
		}
	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderColor : MonoBehaviour
{
     private Slider slider;
 
     public int MaxHealth = 100;
     public Image Fill;  // assign in the editor the "Fill"
     public Color MaxHealthColor = Color.green;
     public Color MinHealthColor = Color.red;
 
     private void Start() {
         slider = gameObject.GetComponent<Slider>();
         slider.value = MaxHealth;        // start with full health
     }

     private void Update()
     {
         Fill.color = Color.Lerp(MinHealthColor, MaxHealthColor, (float)slider.value / MaxHealth);
     }
 }
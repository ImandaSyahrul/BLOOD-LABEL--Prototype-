﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGMSliderVolume : MonoBehaviour
{
    public Slider Volume;

    public AudioSource myMusic;
    // Start is called before the first frame update
    //void Start()
    //{
    //    
    //}
    //
    // Update is called once per frame
    void Update()
    {
        myMusic.volume = Volume.value;

    }
}

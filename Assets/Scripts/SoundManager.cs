﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource BackGroundMusic;
    public void Awake()
    {
        BackGroundMusic.Play();
    }
}

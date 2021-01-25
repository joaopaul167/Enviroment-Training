﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition; 
using UnityEngine.Rendering;
public class App: MonoBehaviour {

 [SerializeField]
 Volume volume;
 
 [SerializeField]
 HDRISky sky;
 
 float skyRotationAmountPerFrame = 0.1f;
 
 void Awake()
 {
      volume.profile.TryGet(out sky);
 }
 
 void Update()
 {
        sky.rotation.value = Mathf.Lerp(sky.rotation.value, sky.rotation.value + 10, skyRotationAmountPerFrame * Time.deltaTime);
        if (sky.rotation.value == sky.rotation.max)
        {
            sky.rotation.value = 0;
        }
 }
}
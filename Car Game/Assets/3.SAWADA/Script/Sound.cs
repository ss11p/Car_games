﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Sound : MonoBehaviour
{
    public AudioSource titleBGM;
    private string beforeScene = "Taitol";
    // Start is called before the first frame update
    void Start()
    {
        titleBGM.Play();
        DontDestroyOnLoad(gameObject);
        DontDestroyOnLoad(titleBGM.gameObject);
        SceneManager.activeSceneChanged += OnActiveSceneChanged;
    }
    void OnActiveSceneChanged(Scene prevScene, Scene nextScene)
    {
        if (beforeScene == "Select" && nextScene.name == "Main")
        {
            titleBGM.Stop();
        }
        if (beforeScene == "Select" && nextScene.name == "Main2")
        {
            titleBGM.Stop();
        }
        if (beforeScene == "Select" && nextScene.name == "Main3")
        {
            titleBGM.Stop();
        }
        if (beforeScene == "Select" && nextScene.name == "Main4")
        {
            titleBGM.Stop();
        }
     
        if (beforeScene == "Main" && nextScene.name == "Select")
        {
            titleBGM.Play();
        }
        if (beforeScene == "Main2" && nextScene.name == "Select")
        {
            titleBGM.Play();
        }
        if (beforeScene == "Main3" && nextScene.name == "Select")
        {
            titleBGM.Play();
        }
        if (beforeScene == "Main4" && nextScene.name == "Select")
        {
            titleBGM.Play();
        }
        beforeScene = nextScene.name;
    }
        // Update is called once per frame
        void Update()
    {
      
    }
}

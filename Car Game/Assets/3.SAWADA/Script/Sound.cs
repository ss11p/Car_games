using System.Collections;
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
        if (beforeScene == "Rezaruto" && nextScene.name == "Taitol")
        {
            titleBGM.Play();
        }
        if (beforeScene == "Main" && nextScene.name == "Taitol")
        {
            titleBGM.Play();
        }
        if (beforeScene == "Main2" && nextScene.name == "Taitol")
        {
            titleBGM.Play();
        }
        if (beforeScene == "Main" && nextScene.name == "Select")
        {
            titleBGM.Play();
        }
        if (beforeScene == "Main2" && nextScene.name == "Select")
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

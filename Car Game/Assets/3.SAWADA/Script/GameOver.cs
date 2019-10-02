using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    public GameObject GameOverCanvas;
    Car carsuript1;
    GameObject Car_root;
    void Start()
    {
        Car_root = GameObject.FindGameObjectWithTag("Car");
    }

    public void Ontaitol()
    {
        SceneManager.LoadScene("Taitol");
        Time.timeScale = 1f;
    }
    public void Onplay()
    {
        Scene loadScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(loadScene.name);
        Time.timeScale = 1f;
    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
    }
}

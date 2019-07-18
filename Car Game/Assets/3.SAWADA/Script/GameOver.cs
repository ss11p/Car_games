using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{     //生成する車
    public GameObject[] Cars = new GameObject[2];
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
    }
    public void Onplay()
    {
        SceneManager.LoadScene("Select");
        }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
    }
}

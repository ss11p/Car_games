using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{     //生成する車
    public GameObject[] Car = new GameObject[2];
    public GameObject GameOverCanvas;
    public void Ontaitol()
    {
        SceneManager.LoadScene("Taitol");
    }
    public void Onplay()
    {
        switch (PlayerPrefs.GetInt("car_selt"))
        {
            case 1:
                Instantiate(Car[0], new Vector3(-64, 1, 57), Quaternion.identity);
                break;
            case 2:
                Instantiate(Car[1], new Vector3(-64, 1, 53), Quaternion.identity);
                break;
            default:
                break;

        }
        var kauntotime = Timer.instar;
        kauntotime.timer += 60.0f;
        kauntotime.countbool = true;
        GameOverCanvas.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

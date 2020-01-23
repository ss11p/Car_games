using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PozuMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 public   void ReSentaku()
    {
        SceneManager.LoadScene("Select");
        Time.timeScale = 1;
       
    }
 public   void Retaitol()
    {
        SceneManager.LoadScene("Taitol");
        Time.timeScale = 1;
    }
}

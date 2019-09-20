using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Rezarut : MonoBehaviour
{
    public Text RezarutoText;
    public static int Scnenes;
 public   void Ontaitol()
    {
        SceneManager.LoadScene("Taitol");
    }
public    void Onplay()
    {
        if (Scnenes == 1)
        {
            SceneManager.LoadScene("Main");
        }
        if (Scnenes == 2)
        {
            SceneManager.LoadScene("Main2");
        }


    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RezarutoText.text = "集めた荷物の数：" + Nimotu.nimotu;
    }
}

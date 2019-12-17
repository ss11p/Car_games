using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rezarut : MonoBehaviour
{
   
    public static int Scnenes;
 public   void Ontaitol()
    {
        SceneManager.LoadScene("Taitol");
    }
public    void Onplay()
    {
        if (SceneManager.GetActiveScene().name == "Rezaruto")
        {
            SceneManager.LoadScene("Main");
        }
        if (SceneManager.GetActiveScene().name == "Rezaruto2")
        {
            SceneManager.LoadScene("Main2");
        }
        if (SceneManager.GetActiveScene().name == "Rezaruto3")
        {
            SceneManager.LoadScene("Main3");
        }
        if (SceneManager.GetActiveScene().name == "Rezaruto4")
        {
            SceneManager.LoadScene("Main4");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Scnenes);

    }

    // Update is called once per frame
    void Update()
    {
        
       
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Rezarut : MonoBehaviour
{
 public   void Ontaitol()
    {
        SceneManager.LoadScene("Taitol");
    }
public    void Onplay()
    {
        SceneManager.LoadScene("Main");
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

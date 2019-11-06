using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Golu : MonoBehaviour
{
    public string LoadName;
    public Timer times;
  
   
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Main")
        {
            Rezarut.Scnenes = 1;
        }
        if (SceneManager.GetActiveScene().name == "Main2")
        {
            Rezarut.Scnenes = 2;
        }
    }
    void OnTriggerEnter(Collider coll)
    {
        var timers = Timer.instar;
        if (timers.timer> 0)
        {
            if (coll.gameObject.tag == "Car")
            {
                Invoke("GoRzalt", 1.0f);
               
            }
        }
    }
    void GoRzalt()
    {

        SceneManager.LoadScene(LoadName);

    }
}

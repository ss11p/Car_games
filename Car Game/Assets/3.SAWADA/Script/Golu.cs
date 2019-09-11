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
      
    }
    void OnTriggerEnter(Collider coll)
    {
        var timers = Timer.instar;
        if (timers.timer> 0)
        {
            if (coll.gameObject.tag == "Car")
            {
                Invoke("GoRzalt", 1.0f);
                Debug.Log("ゴールしました");
            }
        }
    }
    void GoRzalt()
    {

        SceneManager.LoadScene(LoadName);

    }
}

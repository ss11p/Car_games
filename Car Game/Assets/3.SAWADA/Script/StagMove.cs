using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StagMove : MonoBehaviour
{
 
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Stagidou()
    {
        switch (PlayerPrefs.GetInt("Stag_selt"))
        {
            case 1:
                SceneManager.LoadScene("Main");
                break;
            case 2:
                SceneManager.LoadScene("Main2");
                break;
            default:
                break;
        }
    }
}

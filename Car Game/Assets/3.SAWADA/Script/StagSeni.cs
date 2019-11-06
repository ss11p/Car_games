using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StagSeni : MonoBehaviour
{
 
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteKey("Stag_selt");
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SelectClick(int number)
    {
        switch (number)
        {
            case 0:
                SceneManager.LoadScene("Main");
                break;
            case 1:
                SceneManager.LoadScene("Main2");
                break;
            case 2:
                SceneManager.LoadScene("Main3");
                break;
            default:
                break;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StagSeni : MonoBehaviour
{
    public string LoadName;
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
                PlayerPrefs.SetInt("Stag_selt", 1);
                SceneManager.LoadScene(LoadName);
                break;
            case 1:
                PlayerPrefs.SetInt("Stag_selt", 2);
                SceneManager.LoadScene(LoadName);
                break;
            default:
                break;
        }
    }
}

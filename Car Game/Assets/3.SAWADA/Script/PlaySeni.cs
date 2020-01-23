using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlaySeni : MonoBehaviour
{
    float TimeCount = 0.2f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeCount -= Time.deltaTime;
        if (TimeCount <= 0)
        {
            SceneManager.LoadScene("Taitol");
        }

        }
}

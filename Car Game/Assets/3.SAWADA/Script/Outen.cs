using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outen : MonoBehaviour
{
    public GameObject GameoverCanvas;
    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "GameOver")
        {
            StartCoroutine("GameOverCanvas");
        }
    }
    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "GameOver")
        {
            StopCoroutine("GameOverCanvas");
        }
        }
    IEnumerator GameOverCanvas()
    {
      
        yield return new WaitForSeconds(5);
        GameoverCanvas.SetActive(true);
        if (GameoverCanvas.activeSelf)
        {
            Time.timeScale = 0f;
        }else
        {
            Time.timeScale = 1f;
        }
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

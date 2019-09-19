using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pozu : MonoBehaviour
{
    [SerializeField]
    public GameObject pozuCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            pozuCanvas.SetActive(!pozuCanvas.activeSelf);
            if (pozuCanvas.activeSelf)
            {
                Time.timeScale = 0f;
            }
            else
            {
                Time.timeScale = 1f;
            }
        }
    }
}

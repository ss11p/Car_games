using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zyougai : MonoBehaviour
{
    public GameObject GameoverCanvas;

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Car")
        {
            GameoverCanvas.SetActive(true);
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

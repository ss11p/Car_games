using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golu : MonoBehaviour
{
    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Car")
        {
          
            Debug.Log("ゴールしました");
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

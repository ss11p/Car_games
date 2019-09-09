using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChekPoint : MonoBehaviour
{
    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Car")
        {
            var cartimar = Timer.instar;
            cartimar.timer += 10.0f;
            Debug.Log("ChekPoint");
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

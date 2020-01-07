using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSelect3 : MonoBehaviour
{
    public GameObject Car;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Car, new Vector3(-4, 3, 267), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Carseitei : MonoBehaviour
{
    public GameObject Car;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Car, new Vector3(-76.2f, 2, 63.6f), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}

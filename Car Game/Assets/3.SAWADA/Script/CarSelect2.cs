using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSelect2 : MonoBehaviour
{
    public GameObject Car;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Car, new Vector3(-53f, 20, 66.6f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

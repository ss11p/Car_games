using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Move: MonoBehaviour
{
    public GameObject car;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        car = GameObject.FindGameObjectWithTag("Car");
        offset = transform.position - car.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = car.transform.position + offset;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testmove : MonoBehaviour
{
    public Rigidbody testPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            testPlayer.AddForce(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            testPlayer.AddForce(1, 0, 0);
        }
    }
}

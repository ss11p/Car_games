using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float Player_Jump;
    public bool Jumps;
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Player = GameObject.FindGameObjectWithTag("Car");
    }
    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Car")
        {
            if (Jumps)
            {
                Player.GetComponent<Rigidbody>().AddForce(transform.up * Player_Jump * Time.deltaTime, ForceMode.Impulse);            }
        }
    }
}

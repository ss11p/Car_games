using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarAction : MonoBehaviour
{
    //吹っ飛ぶアクションさせるオブジェクト
    public Rigidbody EnemyObj;

    public float Actionspeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision colobj)
    {
        //Playerと接触したら
        if (colobj.gameObject.tag == "Car")
        {
            //↑方向に飛ばす
            EnemyObj.AddForce(transform.up * Actionspeed);
        }
    }
}

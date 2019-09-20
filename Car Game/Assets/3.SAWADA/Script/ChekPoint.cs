using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChekPoint : MonoBehaviour
{
    public GameObject thisChekPoint;
    public GameObject NextChekpoint;
    //チェックポイントに来た際一度だけ制限時間を加算する際の判別
    bool Checkbool = true;
   
    void OnTriggerEnter(Collider coll)
    {
        if (Checkbool == true)
        {
            if (coll.gameObject.tag == "Car")
            {

                Nimotu.nimotu += 1;
                Debug.Log("ChekPoint");
                NextChekpoint.SetActive(!NextChekpoint.activeSelf);              //制限時間を追加したらfalseにしてもう一度加算しないようにする
                thisChekPoint.SetActive(false);
            }
          
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

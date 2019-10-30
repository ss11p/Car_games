using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChekPoint2 : MonoBehaviour
{
    public GameObject thisChekPoint;
    public GameObject NextChekPoint;
    bool Checkbool = true;
    GameObject Chekpointes;
    Chekpoints scpit;
    // Start is called before the first frame update
    void Start()
    {
        Chekpointes = GameObject.Find("ChekPoints");
        scpit = Chekpointes.GetComponent<Chekpoints>();
    }
    void OnTriggerEnter(Collider coll)
    {
        if (Checkbool == true)
        {
            if (coll.gameObject.tag == "Car")
            {

                Nimotu2.nimotu2 += 1;
                scpit.Active();
                thisChekPoint.SetActive(false);
                if (scpit.ActiveObj[0].activeSelf == false)
                {
                    if (scpit.ActiveObj[1].activeSelf == false)
                    {
                        if (scpit.ActiveObj[2].activeSelf == false)
                        {
                            if (scpit.ActiveObj[3].activeSelf == false)
                            {
                                if (scpit.ActiveObj[4].activeSelf == false)
                                {
                                    NextChekPoint.SetActive(true);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
                    // Update is called once per frame
                    void Update()
    {
        
    }
}

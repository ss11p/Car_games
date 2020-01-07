﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChekPoint3 : MonoBehaviour
{
    public AudioClip sound2;
    AudioSource audioSource;
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
        audioSource = GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider coll)
    {
        if (Checkbool == true)
        {
            if (coll.gameObject.tag == "Car")
            {
                audioSource.PlayOneShot(sound2);
                Nimotu3.nimotu3+= 1;
                StartCoroutine("DestrroyChekpoint");
            }
        }
    }
    IEnumerator DestrroyChekpoint()
    {
        yield return new WaitForSeconds(0.2f);
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

        // Update is called once per frame
        void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RezarutoText3 : MonoBehaviour
{
    public Text Rezarutotext3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rezarutotext3.text = "集めた荷物の数:" + Nimotu3.nimotu3;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RezarutoText4 : MonoBehaviour
{
    public Text Rezarutotext4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rezarutotext4.text = "集めた荷物の数：" + Nimotu4.nimotu4;
    }
}

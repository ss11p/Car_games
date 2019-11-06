using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RezarutoText : MonoBehaviour
{
    public Text RezarutoText1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RezarutoText1.text = "集めた荷物の数：" + Nimotu.nimotu;
    }
}

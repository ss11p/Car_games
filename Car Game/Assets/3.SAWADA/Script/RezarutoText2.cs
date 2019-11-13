using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RezarutoText2 : MonoBehaviour
{
    public Text Rezarutotext2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rezarutotext2.text = "集めた荷物の数:" + Nimotu2.nimotu2;
    }
}

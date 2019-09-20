using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Nimotu : MonoBehaviour
{
    public Text nimtuText;
 public static   int nimotu;
    // Start is called before the first frame update
    void Start()
    {
        nimotu = 0;
    }

    // Update is called once per frame
    void Update()
    {
        nimtuText.text = "届けた荷物の数:" + nimotu;
    }
}

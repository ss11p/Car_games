using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nimotu3 : MonoBehaviour
{
    public Text NimotuText;
    public static int nimotu3;
    // Start is called before the first frame update
    void Start()
    {
        nimotu3 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        NimotuText.text = "=" + nimotu3;
    }
}

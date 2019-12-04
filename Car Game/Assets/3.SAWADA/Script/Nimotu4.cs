using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Nimotu4 : MonoBehaviour
{
    public Text NimotuText;
    public static int nimotu4;
    // Start is called before the first frame update
    void Start()
    {
        nimotu4 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        NimotuText.text = "=" + nimotu4;
    }
}

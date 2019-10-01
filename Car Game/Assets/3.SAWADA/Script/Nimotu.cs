using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nimotu : MonoBehaviour
{
  
 public static   int nimotu;
    // Start is called before the first frame update
    void Start()
    {
        nimotu = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMesh>().text = "=" + nimotu;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheeRotationl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ｘの方に回転させるだけｗ
        transform.Rotate(Vector3.right * 1000 * Time.deltaTime);
    }
}

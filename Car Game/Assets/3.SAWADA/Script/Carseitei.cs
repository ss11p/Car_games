using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carseitei : MonoBehaviour
{     //生成する車
    public GameObject[] Car = new GameObject[2];

    // Start is called before the first frame update
    void Start()
    {
        
        switch (PlayerPrefs.GetInt("car_selt"))
        { 
            case 1:
                Instantiate(Car[0], new Vector3(-76.2f, 2, 63.6f), Quaternion.identity);
                break;
            case 2:
                Instantiate(Car[1], new Vector3(-76.2f, 2, 63.6f), Quaternion.identity);
                break;
            default:
                break;

        }

        }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}

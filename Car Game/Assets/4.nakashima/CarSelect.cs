using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CarSelect : MonoBehaviour
{
    
    
    //キャンバス
    public GameObject CarSelectCanvas;
    //ボタンの上にある車
    public GameObject[] ButtonCar = new GameObject[2];

  
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteKey("car_selt");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectClick(int number)
    {
        switch (number)
        {
            case 0:
                PlayerPrefs.SetInt("car_selt",1);
               
                break;
            case 1:
                PlayerPrefs.SetInt("car_selt", 2);
               
                break;
            default:
                break;
        }
    }
 
    //Instatiateで呼び出しは確定
    //ステージ選択と同じ感じで選んだらCanvasを消してゲームを開始する
}

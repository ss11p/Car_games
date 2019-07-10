using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSelect : MonoBehaviour
{
    //キャンバス
    public GameObject CarSelectCanvas;
    //ボタンの上にある車
    public GameObject[] ButtonCar = new GameObject[2];

    //生成する車
    public GameObject[] Car = new GameObject[2];
    
    // Start is called before the first frame update
    void Start()
    {
        
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
                //Car選択のCanvasを消す
                CarSelectCanvas.SetActive(false);
                //Buttonの上にある車を消す
                ButtonCar[0].SetActive(false);
                ButtonCar[1].SetActive(false);
                //選ばれた車を生成する
                Instantiate(Car[0], new Vector3(0, 0, 0), Quaternion.identity);
                break;
            case 1:
                //Car選択のCanvasを消す
                CarSelectCanvas.SetActive(false);
                //Buttonの上にある車を消す
                ButtonCar[0].SetActive(false);
                ButtonCar[1].SetActive(false);
                //選ばれた車を生成する
                Instantiate(Car[1], new Vector3(0, 0, 0), Quaternion.identity);
                break;
            default:
                break;
        }
    }

    //Instatiateで呼び出しは確定
    //ステージ選択と同じ感じで選んだらCanvasを消してゲームを開始する
}

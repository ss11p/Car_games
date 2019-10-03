using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    //カウント3秒
    public float Count = 4;
    //少数を出さないようにする
    int second;
    //表示するText
    public Text TimerText;

    //Findで取得したオブジェクトを入れる
    public GameObject PlayerObj;
    //カウントダウンを止めるBool
    bool CountBool = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //PlayerのTag検索
        PlayerObj = GameObject.Find("F1_root");
        //var obj = PlayerObj.GetComponent<Car>();
        if(CountBool == true)
        {
            Count -= Time.deltaTime;           
        }
        second = (int)Count;
        //textに表示
        TimerText.text = second.ToString();

        if (second == 3)
        {
            //SEとかそういうの入れるならここ
        }
        if (second == 2)
        {
            
        }
        if (second == 1)
        {

        }

        if (second == 0)
        {
            //カウントダウンを止める
            CountBool = false;
            
            //プレイヤーを移動させるScriptをTrueにする
            PlayerObj.GetComponent<Car>().enabled = true;
            //1秒後textを消す
            Invoke("TextActive", 1);
        }
    }
    void TextActive()
    {
        //カウントダウンが終わったらこのScriptを止める
        this.GetComponent<CountDown>().enabled = false;
        //カウントダウンのText（この場合アタッチ先がText）を消す
        gameObject.SetActive(false);      
    }
}

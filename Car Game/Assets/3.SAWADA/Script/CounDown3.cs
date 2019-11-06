using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CounDown3 : MonoBehaviour
{  //カウント3秒
    public float Count = 4;
    //少数を出さないようにする
    int second;
    //表示するText
    public Text TimerText;
    public GameObject CountDouns;
    //Findで取得したオブジェクトを入れる
    GameObject PlayerObj3;
    //カウントダウンを止めるBool
    bool CountBool = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerObj3 = GameObject.Find("SUV");
        Debug.Log(PlayerObj3);
        PlayerObj3.GetComponent<Car>().enabled = false;
        var timar = Timer.instar;
        timar.countbool = false;
        if (CountBool == true)
        {
            Count -= Time.deltaTime;
        }
        second = (int)Count;
        //textに表示
        TimerText.text = second.ToString();
        if (second == 0)
        {
            //カウントダウンを止める
            CountBool = false;

            //プレイヤーを移動させるScriptをTrueにする
            PlayerObj3.GetComponent<Car>().enabled = true;
            timar.countbool = true;
            //1秒後textを消す
            Invoke("TextActive", 1);
        }
    }
    void TextActive()
    {
        //カウントダウンが終わったらこのScriptを止める
        this.GetComponent<CounDown3>().enabled = false;
        //カウントダウンのText（この場合アタッチ先がText）を消す
        CountDouns.SetActive(false);

    }
}

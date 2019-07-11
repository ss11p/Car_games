using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer;
    //カウントが終わったら出す画像？
    public GameObject endimage;
    //カウントダウン入れるテキスト
    public Text countText;
    //カウントダウンで使う
    bool countbool = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CountBool();
        countText.text = timer.ToString("f2") + "秒";
        if(timer <= 0)
        {
            countbool = false;
            countText.text = "0.00" + "秒";
            endimage.SetActive(true);
        }
    }

    void CountBool()
    {
        if(countbool == true)
        {
            timer -= Time.deltaTime;
        }
    }
}

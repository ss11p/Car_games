using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    //タイマーから数字を受け取れるようにする
    public Timer timer;
    //チェックポイントに来た際一度だけ制限時間を加算する際の判別
    bool Checkbool = true;
    //加算する時間を入れる場所
    float Plustime = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckScript();
    }

    void CheckScript()
    {
        if(Checkbool == true)
        {
            //現状条件がわからないからとりあえず左クリックにしてる
            if (Input.GetMouseButtonDown(0))
            {
                //timerに○○ｓ加算する
                timer.timer += Plustime;
                //制限時間を追加したらfalseにしてもう一度加算しないようにする
                Checkbool = false;
            }
        }        
    }
}

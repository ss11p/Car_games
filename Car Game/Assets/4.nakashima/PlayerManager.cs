using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    //加速
    public float Accel;
    //旋回
    public float Turn;
    private Rigidbody CarRb;
    //車の速度を入れる変数
    private float CarSpeed;
    //押している時間の測定
    private float Count;
    //タイヤの旋回
    public float WheelTurn;
    //タイヤで使う旋回の限界値
    private float MaxWheelTurn = 45f;
    //前輪タイヤ
    public GameObject WheelR;
    public GameObject WheelL;
    // Start is called before the first frame update
    void Start()
    {
        Count = 0f;
        CarSpeed = 0f;
        CarRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        //前移動 
        if (Input.GetButtonDown("Vertical"))
        {
            CarSpeed += Accel * Time.deltaTime;
        }
        //後移動 ↓矢印キー
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //減速めんどいし取り合えず 0
            CarSpeed -= CarSpeed;
            //CarSpeed -= Accel * Time.deltaTime;
            /*if(CarSpeed < 0)
            {
                CarSpeed = 0;
            }*/
        }

        CarRb.velocity = transform.forward * CarSpeed;
        //左右キーのを入れる
        float Handle = Input.GetAxis("Horizontal");
        //旋回させる
        transform.Rotate(Vector3.up, Turn * Handle * Time.deltaTime);

        //前輪2つのタイヤの向きを変更する
        WheelR.transform.Rotate(Vector3.up, WheelTurn * Handle * Time.deltaTime);
        WheelL.transform.Rotate(Vector3.up, WheelTurn * Handle * Time.deltaTime);
        if (WheelTurn > MaxWheelTurn)
        {
            //タイヤの旋回の限界値にする
            WheelTurn = MaxWheelTurn;
        }

        //左右キーの入力判定を取る＋α
        if (Input.GetButton("Horizontal"))
        {
            //押している時間
            Count += Time.deltaTime;
            //○○秒経過していたら
            if(Count >= 2f)
            {
                //左右どちらかの入力かの判別
                //+　右
                if(Handle > 0)
                {
                    //右ドリフトのエフェクト

                }
                //-　左
                if(Handle < 0)
                {
                    //左ドリフトのエフェクト

                }
                //　SE
                //スコア的な要素をいれるならここでも入れれる
            }
        }
        //左右キーを離したら
        if (Input.GetButtonUp("Horizontal"))
        {
            //押している時間の初期化
            Count = 0f;
            Debug.Log("離した");

            //ここでタイヤの旋回を0に戻る予定だった、戻ってない
            WheelTurn = 0f;
            WheelR.transform.Rotate(Vector3.up,WheelTurn);
            WheelL.transform.Rotate(Vector3.up,WheelTurn);
        }
    }
}

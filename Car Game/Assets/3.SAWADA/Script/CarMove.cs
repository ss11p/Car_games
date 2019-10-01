using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    public float speed = 3.0f;
    private Vector3 Player_pos; //プレイヤーのポジション
    // Start is called before the first frame update
    void Start()
    {

        Player_pos = GetComponent<Transform>().position; //最初の時点でのプレイヤーのポジションを取得
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
          
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
        Vector3 diff = transform.position - Player_pos; //プレイヤーがどの方向に進んでいるかがわかるように、初期位置と現在地の座標差分を取得

        if (diff.magnitude > 0.01f) //ベクトルの長さが0.01fより大きい場合にプレイヤーの向きを変える処理を入れる(0では入れないので）
        {
            transform.rotation = Quaternion.LookRotation(diff);  //ベクトルの情報をQuaternion.LookRotationに引き渡し回転量を取得しプレイヤーを回転させる
        }

        Player_pos = transform.position; //プレイヤーの位置を更新


    }
}

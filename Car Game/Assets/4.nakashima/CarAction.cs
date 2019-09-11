
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarAction : MonoBehaviour
{
    //吹っ飛ぶアクションさせるオブジェクト、オブジェクト自身
    public GameObject EnemyObj;
    Rigidbody EnemyRb;
    //吹っ飛ぶ力
    public float Actionspeed = 100f;
    //関数にアクセスする
    public GameObject test1;
    //増加させるスコア
    public int PlasScore;
    // Start is called before the first frame update
    void Start()
    {
        //オブジェクトのrbを取得
        EnemyRb = EnemyObj.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision colobj)
    {
        //Playerと接触したら
        if (colobj.gameObject.tag == "Player")
        {
            //↑方向に飛ばす
            EnemyRb.AddForce(transform.up * Actionspeed);

            //オブジェクトを非表示にする
            StartCoroutine(EnemyActive());
            //SEもここかな、吹っ飛ばすだけのSE

            //スコアを加算させる？
            //とりあえず単体のスコアだけ出す
            //scoreManager.GetComponent<ScoreManager>().Init(PlasScore, new Vector3(Random.Range(-200.0f,200.0f),Random.Range(-200.0f,200.0f),0));
            test1.GetComponent<test1>().Score(PlasScore);

        }
    }
    IEnumerator EnemyActive()
    {
        //○○秒後
        yield return new WaitForSeconds(1f);
        //消す
        //吹っ飛んだ後のSE、エフェクト入れる？

        EnemyObj.SetActive(false);
    }
}

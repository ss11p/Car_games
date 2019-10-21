using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    //プレイヤーを追尾可能になった（障害物にぶつかってもぶつかり続ける）

    //巡回する点
    public Transform[] points;

    int destPoint = 0;
    private NavMeshAgent agent;

    public float distance;
    //追尾し始まる範囲
    //float trackingRange = 30f;
    //巡回に戻る範囲
    //float quitRange = 40f;
    bool tracking = false;

    public string PlayerName;

    //プレイヤーが入る変数（追尾対象）
    private GameObject Target;
    //↑のポジションを入れる変数
    private Vector3 TargetPos;
    

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        agent.autoBraking = false;
        GotoNextPoint();
    }
    void GotoNextPoint()
    {
        if (points.Length == 0)
            return;

        //agentが設定された目標地点に行くように設定
        agent.destination = points[destPoint].position;
        //配列内の次の位置を目標地点にして、必要なら出発地点に戻る
        destPoint = (destPoint + 1) % points.Length;
    }

    // Update is called once per frame
    void Update()
    {
        //↓のだと重くなる、カクつくならどうにかする（かもかも）
        //プレイヤーの名前を検索して変数にいれる
        Target = GameObject.Find(PlayerName);
        //追尾する対象の場所取得
        TargetPos = Target.transform.position;
        distance = Vector3.Distance(this.transform.position, TargetPos);
        Movemove();
    }

    //void Move()
    //{
    //    //moveTime -= Time.deltaTime;
    //    if (tracking)
    //    {
    //        //追跡時quitRangeより距離が離れたら中止
    //        if (distance > quitRange)
    //        {
    //            tracking = false;
    //        }
    //        //プレイヤーを追尾
    //        agent.destination = TargetPos;
    //    }
    //    else
    //    {
    //        //TargetがtrackingRangeより近づいたら追跡開始
    //        if (distance < trackingRange)
    //        {
    //            tracking = true;
    //        }
    //        if (!agent.pathPending && agent.remainingDistance < 0.5f)
    //        {
    //            GotoNextPoint();
    //        }
    //    }
    //}

    //void OnDrawGizmosSelected()
    //{
    //    //範囲の表示trackingRange
    //    Gizmos.color = Color.red;
    //    Gizmos.DrawWireSphere(transform.position, trackingRange);

    //    //範囲の表示quitRange
    //    Gizmos.color = Color.blue;
    //    Gizmos.DrawWireSphere(transform.position, quitRange);
    //}
    void Movemove()
    {
        if (tracking)
        {
            //プレイヤーを追尾
            agent.destination = TargetPos;
        }

        else
        {
            if (!agent.pathPending && agent.remainingDistance < 0.5f)
            {
                GotoNextPoint();
            }
        }
    }

    void OnTriggerEnter(Collider colStay)
    {
        //プレイヤーに設定しているトリガー範囲に入ったら～
        if(colStay.gameObject.name == PlayerName)
        {
            //追尾開始
            tracking = true;
        }
    }
    void OnTriggerExit(Collider colExit)
    {
        //プレイヤーに設定しているトリガーの範囲から離れたらーEnemyにもTrigger入れないとダメ
        if (colExit.gameObject.name == PlayerName)
        {
            //追尾をやめる
            tracking = false;
        }
    } 
    
    void　OnCollisionEnter(Collision collisionEnter)
    {
        if(collisionEnter.gameObject.name == "SUV Body")
        {
            tracking = false;
        }
    }
}

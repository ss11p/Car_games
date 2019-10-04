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

    float distance;

    float trackingRange = 3f;
    float quitRange = 5f;
    bool tracking = false;

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

    // Update is called once per frame
    void Update()
    {
        //↓のだと重くなる、カクつくならどうにかする（かもかも）
        //プレイヤーの名前を検索して変数にいれる
        Target = GameObject.Find("F1_root");
        //追尾する対象の場所取得
        TargetPos = Target.transform.position;
        distance = Vector3.Distance(this.transform.position, TargetPos);


        //追尾する対象がいるかどうか
        if(Target != null)
        {
            Move();
        }
    }

    void Move()
    {
        //moveTime -= Time.deltaTime;
        if(tracking == true)
        {
            //追跡時quitRangeより距離が離れたら中止
            if(distance > quitRange)
            {
                tracking = false;

                agent.destination = TargetPos;
            }      
        }
        if(tracking == false)
        {
            //TargetがtrackingRangeより近づいたら追跡開始
            if(distance < trackingRange)
            {
                tracking = true;
            }
            if(!agent.pathPending && agent.remainingDistance < 0.5f)
            {
                GotoNextPoint();
            }
        }       
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

    void OnDrawGizmosSelected()
    {
        //範囲の表示trackingRange
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, trackingRange);

        //範囲の表示quitRange
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, quitRange);
    }
}

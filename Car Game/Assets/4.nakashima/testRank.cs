using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class testRank : MonoBehaviour
{
    private int testRanking;
    private int[] ranking = new int[5];
    // Start is called before the first frame update
    void Start()
    {
        ranking[0] = 1;
        ranking[1] = 3;
        ranking[2] = 2;
        ranking[3] = 5;
        ranking[4] = 4;
    }

    // Update is called once per frame
    void Update()
    {
        //Linqでソート、降順
        var orderByList = ranking.OrderBy(x => -x);
        foreach(var x in orderByList)
        {
            Debug.Log(x);
        }
        //数字の入れ替えがまだできていない、ここでつまってる

        //PlayerPrefabsを使用するか。。。

        //Debug.Log(ranking.Min());
        




        //ここに数字をいれる
        //testRanking = Nimotu.nimotu;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Ranking3 : MonoBehaviour
{
    public GameObject[] newObject3 = new GameObject[3];
    int point3 = Nimotu3.nimotu3;
    string[] ranking3 = { "ランキング3 １位", "ランキング3 ２位", "ランキング3 3位" };
    int[] rankingValue3 = new int[3];
    [SerializeField, Header("表示させるテキスト")]
    Text[] rankingText3 = new Text[3];

    // Start is called before the first frame update
    void Start()
    {
        GetRanking3();
        SetRanking3(point3);
        if (rankingValue3[0] == point3)
        {
            newObject3[0].SetActive(true);
            newObject3[1].SetActive(false);
            newObject3[2].SetActive(false);
        }
        else if (rankingValue3[1] == point3)
        {
            newObject3[0].SetActive(false);
            newObject3[1].SetActive(true);
            newObject3[2].SetActive(false);
        }
        else if (rankingValue3[2] == point3)
        {
            newObject3[0].SetActive(false);
            newObject3[1].SetActive(false);
            newObject3[2].SetActive(true);
        }
        else
        {
            newObject3[0].SetActive(false);
            newObject3[1].SetActive(false);
            newObject3[2].SetActive(false);
        }

        for (int i = 0; i < ranking3.Length; i++)
        {
            rankingText3[i].text = rankingValue3[i].ToString();
        }
    }
    void GetRanking3()
    {
        for (int i = 0; i < ranking3.Length; i++)
        {
            rankingValue3[i] = PlayerPrefs.GetInt(ranking3[i]);
        }

    }
    void SetRanking3(int _Value3)
    {
        for (int i = 0; i < ranking3.Length; i++)
        {
            if (_Value3 > rankingValue3[i])
            {
                var change3 = rankingValue3[i];
                rankingValue3[i] = _Value3;
                _Value3 = change3;
            }
        }
        for (int i = 0; i < ranking3.Length; i++)
        {
            PlayerPrefs.SetInt(ranking3[i], rankingValue3[i]);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

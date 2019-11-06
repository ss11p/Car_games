using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Ranking : MonoBehaviour
{
    int point = Nimotu.nimotu;
    string[] ranking = { "ランキング１位", "ランキング２位", "ランキング3位" };
    int[] rankingValue = new int[3];
    [SerializeField, Header("表示させるテキスト")]
    Text[] rankingText = new Text[3];
    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.DeleteAll();

        GetRanking();
        SetRanking(point);
        for(int i = 0; i < ranking.Length; i++)
        {
            rankingText[i].text = rankingValue[i].ToString();
        }
        
    }
    void GetRanking()
    {
        for (int i = 0; i < ranking.Length; i++)
        {
            rankingValue[i] = PlayerPrefs.GetInt(ranking[i]);
        }
    }
    void SetRanking(int _Value)
    {
        for(int i = 0; i < ranking.Length; i++)
        {
            if (_Value > rankingValue[i])
            {
                var change = rankingValue[i];
                rankingValue[i] = _Value;
                _Value = change;
            }
        }
        for(int i = 0; i < ranking.Length; i++)
        {
            PlayerPrefs.SetInt(ranking[i], rankingValue[i]);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

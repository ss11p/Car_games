using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Rankig2 : MonoBehaviour
{
    int point2 = Nimotu2.nimotu2;
    string[] ranking2 = { "ランキング2 １位", "ランキング2 ２位", "ランキング2 3位" };
    int[] rankingValue2 = new int[3];
    [SerializeField, Header("表示させるテキスト")]
    Text[] rankingText2 = new Text[3];
    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.DeleteAll();

        GetRanking2();
        SetRanking2(point2);
        for (int i = 0; i < ranking2.Length; i++)
        {
            rankingText2[i].text = rankingValue2[i].ToString();
        }
    }
    void GetRanking2()
    {
        for (int i = 0; i < ranking2.Length; i++)
        {
            rankingValue2[i] = PlayerPrefs.GetInt(ranking2[i]);
        }
    }
    void SetRanking2(int _Value2)
    {
        for (int i = 0; i < ranking2.Length; i++)
        {
            if (_Value2 > rankingValue2[i])
            {
                var change2 = rankingValue2[i];
                rankingValue2[i] = _Value2;
                _Value2 = change2;
            }
        }
        for (int i = 0; i < ranking2.Length; i++)
        {
            PlayerPrefs.SetInt(ranking2[i], rankingValue2[i]);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

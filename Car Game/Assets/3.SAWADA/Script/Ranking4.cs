using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Ranking4 : MonoBehaviour
{
    public GameObject[] newObject4 = new GameObject[3];
    int point4 = Nimotu4.nimotu4;
    string[] ranking4 = { "ランキング4 １位", "ランキング4 ２位", "ランキング4 3位" };
    int[] rankingValue4 = new int[3];
    [SerializeField, Header("表示させるテキスト")]
    Text[] rankingText4 = new Text[3];
    // Start is called before the first frame update
    void Start()
    {
        GetRanking4();
        SetRanking4(point4);
        if (rankingValue4[0] == point4)
        {
            newObject4[0].SetActive(true);
            newObject4[1].SetActive(false);
            newObject4[2].SetActive(false);
        }
        else if (rankingValue4[1] == point4)
        {
            newObject4[0].SetActive(false);
            newObject4[1].SetActive(true);
            newObject4[2].SetActive(false);
        }
        else if (rankingValue4[2] == point4)
        {
            newObject4[0].SetActive(false);
            newObject4[1].SetActive(false);
            newObject4[2].SetActive(true);
        }
        else
        {
            newObject4[0].SetActive(false);
            newObject4[1].SetActive(false);
            newObject4[2].SetActive(false);
        }
        for (int i = 0; i < ranking4.Length; i++)
        {
            rankingText4[i].text = rankingValue4[i].ToString();
        }
    }
    void GetRanking4()
    {
        for (int i = 0; i < ranking4.Length; i++)
        {
            rankingValue4[i] = PlayerPrefs.GetInt(ranking4[i]);
        }

        // Update is called once per frame
    
    }
    void SetRanking4(int _Value4)
    {
        for (int i = 0; i < ranking4.Length; i++)
        {
            if (_Value4 > rankingValue4[i])
            {
                var change4 = rankingValue4[i];
                rankingValue4[i] = _Value4;
                _Value4 = change4;
            }
        }
        for (int i = 0; i < ranking4.Length; i++)
        {
            PlayerPrefs.SetInt(ranking4[i], rankingValue4[i]);
        }
    }
}

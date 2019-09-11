using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class ScoreManager : MonoBehaviour
{
    //スコア、画像でやりたい
    
    Vector3 init_pos;

    public int point;
    private float size = 1.0f;

    private static int dam_sort = 0;
    private const int SORT_MAX = 30000;
    // Start is called before the first frame update
    void Start()
    {
        //↓を条件で使えるようにする
        //Init(300, new Vector3(10, 10, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Init(int point,Vector3 pos)
    {
        //ポジションを変更させたい

        this.point = point;
        CreateNum(point);
        init_pos = pos;
        GetComponent<SortingGroup>().sortingOrder = dam_sort;

        dam_sort++;
        if(dam_sort > SORT_MAX)
        {
            dam_sort = 0;
        }
    }
    private void CreateNum(int point)
    {
        int digit = ChkDigit(point);
        //呼び出す名前
        GameObject obj = LoadGameObject("test", "pref_num_test");
        for(int i = 0; i < digit; i++)
        {
            GameObject numObj = Instantiate(obj) as GameObject;
            //子供として登録
            numObj.transform.parent = transform;
            //現在チェックしている桁の数字を出す
            int digNum = GetPointDigit(point, i + 1);
            //ポイントから数字を切り替える
            numObj.GetComponent<NumCtrl>().ChangeSprite(digNum);
            //サイズを入手する
            //float size_w = numObj.GetComponent<SpriteRenderer>().bounds.size.x;
            float size_w = numObj.GetComponent<SpriteRenderer>().size.x;
            //位置をずらす
            float ajs_x = size_w * i - (size_w * digit) / 2;
            Vector3 pos = new Vector3(numObj.transform.position.x - ajs_x,numObj.transform.position.y,numObj.transform.position.z);
            numObj.transform.position = pos;
            numObj = null;
        }
    }




    public static int ChkDigit(int num)
    {
        //0の場合1桁として返す
        if (num == 0) return 1;
        //対数を使って返す
        return (num == 0) ? 1 : ((int)Mathf.Log10(num) + 1);
    }
    public static int GetPointDigit(int num, int digit)
    {
        int res = 0;
        int pow_dig = (int)Mathf.Pow(10, digit);
        if(digit == 1)
        {
            res = num - (num / pow_dig) * pow_dig;
        }
        else
        {
            res = (num - (num / pow_dig) * pow_dig) / (int)Mathf.Pow(10, digit - 1);
        }

        return res;
    }
    public static GameObject LoadGameObject(string dir_name,string filename)
    {
        GameObject obj;
        //リソースから読み込む
        obj = (GameObject)Resources.Load(dir_name + "/" + filename);
        return obj;
    }
}

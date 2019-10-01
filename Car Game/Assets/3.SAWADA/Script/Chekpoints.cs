using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chekpoints : MonoBehaviour
{
    private List<int> randomList = new List<int>();
    public GameObject[] ActiveObj;
    // Start is called before the first frame update
    void Start()
    {
        Active();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Active()
    {
        //呼び出す際、これを呼び出すScriptに入れる
        //public ObjecetActive objecetActive;
        //objecetActive.Active();


        //基本こちらで呼び出し
        while (true)
        {
            //0～オブジェクトの最大数まで
            var ObjNumber = Random.Range(0, ActiveObj.Length);
            if (randomList.Contains(ObjNumber))
            {
                continue;
            }
            //一度だけ呼び出し
            ActiveObj[ObjNumber].SetActive(true);
        }
      
    }
}

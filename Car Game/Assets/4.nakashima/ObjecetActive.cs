using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjecetActive : MonoBehaviour
{
    //ActiveをfalseにしてあるObjを入れる（個数は自由）
    public GameObject[] ActiveObj;
    // Start is called before the first frame update
    void Start()
    {
        //0～オブジェクトの最大数まで
        var ObjNumber = Random.Range(0, ActiveObj.Length);
        //一度だけ呼び出し
        ActiveObj[ObjNumber].SetActive(true);
        Debug.Log(ActiveObj[ObjNumber] + "呼び出し成功");
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

        //0～オブジェクトの最大数まで
        var ObjNumber = Random.Range(0, ActiveObj.Length);
        //一度だけ呼び出し
        ActiveObj[ObjNumber].SetActive(true);
        Debug.Log(ActiveObj[ObjNumber] + "呼び出し成功");
    }
}

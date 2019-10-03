using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    public static Timer instar;
    public float timer;
    //カウントが終わったら出す画像？
    public  GameObject endimage;
    //カウントダウン入れるテキスト
    public Text countText;
    //カウントダウンで使う
  public  bool countbool = true;
    [SerializeField]
    private int minute;
    [SerializeField]
    private float seconds;
    //　前回Update時の秒数
    private float oldSeconds;

    // Start is called before the first frame update
    void Start()
    {
        instar = this;
        timer= minute * 60 + seconds;
        oldSeconds = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        CountBool();
      

        if(timer <= 0)
        {
            countbool = false;
            countText.text = "0.00" + "秒";
            SceneManager.LoadScene("Rezaruto");
            if (SceneManager.GetActiveScene().name == "Main")
            {
                Rezarut.Scnenes = 1;
            }
            if (SceneManager.GetActiveScene().name == "Main2")
            {
                Rezarut.Scnenes = 2;
            }
        }
    }

    void CountBool()
    {
        if(countbool == true)
        {
            timer = minute * 60 + seconds;
            timer -= Time.deltaTime;
            minute = (int)timer / 60;
            seconds = timer - minute * 60;
            if ((int)seconds != (int)oldSeconds)
            {
                countText.text = minute.ToString("00") + ":" + ((int)seconds).ToString("00");
            }
            oldSeconds = seconds;
        }
    }
}

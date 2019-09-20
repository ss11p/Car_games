using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumCtrl : MonoBehaviour
{
    [SerializeField] private Sprite[] Nimage = new Sprite[10];

    public void ChangeSprite(int no)
    {
        if (no > 9 || no < 0) no = 0;
        SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = Nimage[no];
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

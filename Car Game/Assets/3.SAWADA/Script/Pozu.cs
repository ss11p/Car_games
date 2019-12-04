using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pozu : MonoBehaviour
{
    public GameObject GameoverCanvas;
    public AudioClip sound1;
    public AudioClip sound2;
    AudioSource audioSource;
     
    [SerializeField]
    public GameObject pozuCanvas;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown("q"))
        {
            if (GameoverCanvas.activeSelf == false)
            {

                pozuCanvas.SetActive(!pozuCanvas.activeSelf);
                if (pozuCanvas.activeSelf)
                {
                    audioSource.PlayOneShot(sound1);
                    Time.timeScale = 0f;
                }
                else
                {
                    audioSource.PlayOneShot(sound2);
                    Time.timeScale = 1f;
                }

            }
        }
    }
}

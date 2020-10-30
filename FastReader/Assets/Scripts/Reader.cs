using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reader : MonoBehaviour
{
    [TextArea(3,80)]
    public string fullText;
    public int actualWord = 0;

    public Text showWord;

    public float speed;
    float timer;
    string word;

    private void Start()
    {
        word = fullText.Split(' ')[actualWord];
        timer = speed;
    }

    void Update()
    {
        if(speed > 0)
        {
            speed -= Time.deltaTime;
        }
        else
        {
            ShowNextWord();
            speed = timer;
        }
        showWord.text = word;
    }

    public void ShowNextWord()
    {
        actualWord += 1;
        word = fullText.Split(' ')[actualWord];
    }
}

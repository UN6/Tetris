using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soraColor : MonoBehaviour//空（背景）の色を変えていくプログラム
{
    float G;
    float B;
    int r;      //MouseReactからrを変更していく
    // Start is called before the first frame update
    public void colorChange(int r)
    {
        this.r = r;
    }

    void Start()
    {
        G = 1.0f;
        B = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (r < 50)
        {
            if (B > 0)
            {
                B -= 0.0002f * r;//段々夕暮れの空になる
                G -= 0.0001f * r;
                GetComponent<Renderer>().material.color = new Color(1.0f, G, B, 1.0f);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDirector : MonoBehaviour//スコアの表示に関するプログラム
{
    GameObject scoreText;
    int score = 500; //ゲームシーンからスコアを持ってくる（変更必須）

    // Start is called before the first frame update
    void Start()
    {
        this.scoreText = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {
        this.scoreText.GetComponent<Text>().text = this.score.ToString();
    }
}

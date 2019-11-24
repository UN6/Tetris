using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDirector : MonoBehaviour
{
    GameObject scoreText;
    int score = 500; //ゲームシーンからスコアを持ってくる

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

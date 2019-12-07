using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerToHome : MonoBehaviour//タイトル（スタートシーン）に戻るだけのプログラム
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ToHome()　//タイトル（今はサンプルシーン）に戻る（変更必須）
    {
        SceneManager.LoadScene("SampleScene");
    }
}

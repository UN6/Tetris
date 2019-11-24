using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerToHome : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ToHome()　//タイトル（サンプルシーン）に戻る
    {
        SceneManager.LoadScene("SampleScene");
    }
}

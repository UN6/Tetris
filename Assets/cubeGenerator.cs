using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeGenerator : MonoBehaviour//キューブを作ってランダムに落としているだけ
{
    public GameObject CubePrefab;
    float span = 2.0f;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject Cube = Instantiate(CubePrefab) as GameObject;
            float x = Random.Range(-35, 35);
            Cube.transform.position = new Vector3(x, 25, 0);
        }
    }
}

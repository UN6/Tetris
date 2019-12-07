using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseReact : MonoBehaviour//クリックしたキューブを飛ばすプログラム
{
    public string cubeTag = "cube";
    int a = 0; 
    GameObject haikei;
    // Start is called before the first frame update
    void Start()
    {
        this.haikei = GameObject.Find("sora");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = new Ray();
            RaycastHit hit = new RaycastHit();
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray.origin,ray.direction,out hit, Mathf.Infinity))
            {
                if (hit.collider.gameObject.CompareTag(cubeTag))
                {
                    a++;//背景の色を変えるためのa
                    hit.collider.gameObject.GetComponent<cubeController>().Shoot(new Vector3(0, 1000, 2000));
                    this.haikei.GetComponent<soraColor>().colorChange(a);
                }
            }
        }
    }
}

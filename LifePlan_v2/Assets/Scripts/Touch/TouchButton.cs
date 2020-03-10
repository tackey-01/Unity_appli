using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchButton : MonoBehaviour
{
    public GameObject obj_prefab;
    public bool animation_flag = false;

    // Start is called before the first frame update
    void Start()
    {
               
    }

    // Update is called once per frame
    void Update()
    {
        // Objectが押された


        
    }

    public void OnClick()
    {

        Debug.Log("click");
        // Objectの生成
        Instantiate(obj_prefab);

        // アニメーションの有無
    }

    public void OnDelete()
    {
        Destroy(obj_prefab);
    }

}

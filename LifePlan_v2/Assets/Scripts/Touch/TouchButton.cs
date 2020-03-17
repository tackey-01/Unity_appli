using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TouchButton : MonoBehaviour
{
    public GameObject obj_parent; // 親となるOBJECT

    public GameObject obj_prefab; // コピーするOBJECT

    public bool animation_flag = false; // アニメーションの有無

    // Start is called before the first frame update
    void Start()
    {
               
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Objectが押された
    public void OnClick()
    {

        Debug.Log("click");
        // Objectの生成
        GameObject new_obj = Instantiate(obj_prefab);
        if (obj_parent != null) {
            Debug.Log("obj_Canvas");
            //親に子をセットする
            new_obj.transform.SetParent(obj_parent.transform, false);
            //順番
            new_obj.transform.SetSiblingIndex(obj_parent.transform.GetSiblingIndex());
        }
        

        // アニメーションの有無
    }

    public void OnDelete()
    {
        //object delete
        Destroy(obj_prefab);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScale : MonoBehaviour
{
    float scrollVar;    //滚轮滑动的值
    public float scrollSpeed=10;    //相机缩放速度
    public float limitation=5;    //大小限制
    public float startVar;    //摄像机大小初始值
    // Start is called before the first frame update
    void Start()
    {
        startVar=Camera.main.orthographicSize;    //将摄像机大小初始值赋值给initiaVar
    }

    // Update is called once per frame
    void Update()
    {
        scrollVar=Input.GetAxis("Mouse ScrollWheel")*scrollSpeed*Time.deltaTime;    //滚轮滑动方向*速度
        Camera.main.orthographicSize+=scrollVar;    //摄像机大小+滚轮滑动的值
        Camera.main.orthographicSize=Mathf.Clamp(Camera.main.orthographicSize,startVar-limitation,startVar+limitation);//限制摄像机大小范围
    }
}

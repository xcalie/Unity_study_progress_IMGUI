using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class CustomGUIRoot : MonoBehaviour
{
    private CustomGUIControl[] allControls;


    void Start()
    {
        //在游戏开始时只需要得到一次
        allControls = this.GetComponentsInChildren<CustomGUIControl>();
    }

    //在这统一绘制GUI的内容
    private void OnGUI()
    {
        // 编辑状态下再一直运行,避免性能浪费
        if (!Application.isPlaying)
        {
            // 通过每一次绘制之前 得到所有子对象控件的 父类脚本
            allControls = this.GetComponentsInChildren<CustomGUIControl>();
        }
        // 遍历每一个子类 控制其绘制
        for (int i = 0; i < allControls.Length; i++)
        {
            allControls[i].DrawGUI();
        }
    }
}

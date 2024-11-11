using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IM0009 : MonoBehaviour
{
    public GUIStyle Style;

    public GUISkin Skin;

    private void OnGUI()
    {
        #region 全局颜色

        // 全局的着色颜色 影响背景和文本颜色
        //GUI.color = Color.red;
        // 多次改变会发生叠加 颜色 与 全局颜色叠加

        // 文本着色颜色
        //GUI.contentColor = Color.yellow;
        //GUI.Button(new Rect(0, 0, 100, 30), "测试按钮");

        //GUI.backgroundColor = Color.green;
        //GUI.Label(new Rect(0, 50, 100, 30), "测试文本");

        //GUI.color = Color.red;
        //GUI.Button(new Rect(0, 100, 100, 30), "测试按钮");


        #endregion


        #region 整体皮肤样式

        // GUISkin本质上是一个Style所有格式的集合文件
        // 如果绘制时单独使用GUIStyle文件,会直接执行Style设置无Skin文件
        GUI.skin = Skin;

        GUI.Button(new Rect(0, 100, 100, 30), "测试按钮");
        
        GUI.skin = null;

        GUI.Button(new Rect(0, 150, 100, 30), "测试按钮2");


        #endregion
    }
}

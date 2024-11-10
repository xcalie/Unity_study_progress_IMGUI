using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IM0002_GUI : MonoBehaviour
{
    public Rect rect;
    public Texture tex;

    public Rect rect1;
    public GUIContent content;

    public GUIStyle style;

    public Rect ButtonRect;
    public GUIContent ButtonContent;
    public GUIStyle ButtonStyle;

    private void OnGUI()
    {
        #region GUI绘制的共同点

        // GUI公共类的静态函数 直接调用即可
        // 参数大同小异
        //      位置参数 Rect参数  x y 位置 w h 尺寸
        //      显示信息 string 参数
        //      图片信息 Texture参数
        //      综合信息 GUIContent参数
        //      自定义样式 GUIStyle参数
        //      每一种控件有多种重载，每个都是各种信息的排列组合
        // 必须 位置 显示 信息

        #endregion

        #region 文本控件API

        //基本使用
        GUI.Label(new Rect(0, 0, 100, 20), "泥嚎", style);
        GUI.Label(rect, tex);
        //综合使用
        GUI.Label(rect1, content);
        //可以获取当前鼠标的选中的GUI控件，触发tooltip
        //Debug.Log(GUI.tooltip);

        //自定义样式


        #endregion

        #region 按钮控件

        // 基本使用
        // 综合使用
        // 在按钮范围内 按下鼠标再抬起 才算一次点击
        //if (GUI.Button(ButtonRect, ButtonContent, ButtonStyle))
        //{
        //    //点击逻辑
        //    Debug.Log("按钮被点击");
        //}


        //只要按下就算点击
        if (GUI.RepeatButton(ButtonRect, ButtonContent))
        {
            Debug.Log("长按按钮被点击");
        }

        #endregion
    }
}

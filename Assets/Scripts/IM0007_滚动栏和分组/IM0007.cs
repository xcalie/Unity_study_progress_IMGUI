using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IM0007 : MonoBehaviour
{
    public Rect groupPos;

    public Rect scPos;
    public Rect showPos;

    private Vector2 nowPos;

    private void OnGUI()
    {
        #region 分组

        // 用于批量控制控件的位置
        // 可以理解为 包裹的空间有一个父类
        // 控制分组来批量控制组件
        GUI.BeginGroup(groupPos);

        // 这里的位置为相对位置
        GUI.Button(new Rect(0, 0, 100, 30), "测试按钮");
        GUI.Label(new Rect(0, 60, 100, 30), "测试文本");

        GUI.EndGroup();

        #endregion


        #region 滚动列表

        // 后面两个bool类型的数组，为是否超过内容显示滚动条
        nowPos = GUI.BeginScrollView(scPos, nowPos, showPos, false, false);

        // 这里的位置为相对showPos位置 showPos为底图的长宽， scPos为显示框的长宽
        GUI.Button(new Rect(0, 0, 100, 30), "测试按钮");
        GUI.Label(new Rect(0, 60, 100, 30), "测试文本");

        GUI.EndClip();

        #endregion
    }
}

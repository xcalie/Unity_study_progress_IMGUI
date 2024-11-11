using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IM0003_MoreSelect : MonoBehaviour
{

    private bool isSel;
    private bool isSel2;

    public GUIContent content;
    public GUIStyle style;

    private int nowSelIndex = 1;

    private void OnGUI()
    {
        #region 多选框

        #region 普通样式

        // 传一个bool值根据返回值变换状态
        isSel = GUI.Toggle(new Rect(0, 0, 100, 30), isSel, "效果开关");

        #endregion

        #region 自定义样式 显示问题

        // 修改固定宽高 fixedWidth 和 fixedHeight
        // 修改从GUIStyle边缘到内容起始处的空间 padding

        isSel2 = GUI.Toggle(new Rect(0, 40, 100, 30), isSel2, content, style);

        #endregion

        #region 单选框

        // 基于多选框实现
        // 关键：通过一个int标识来决定是否选中
        if (GUI.Toggle(new Rect(0, 100, 100, 30), nowSelIndex == 1, "选项一"))
        {
            nowSelIndex = 1;
        }
        if (GUI.Toggle(new Rect(0, 140, 100, 30), nowSelIndex == 2, "选项二"))
        {
            nowSelIndex = 2;
        }
        if (GUI.Toggle(new Rect(0, 180, 100, 30), nowSelIndex == 3, "选项三"))
        {
            nowSelIndex = 3;
        }


        #endregion


        #endregion
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class IM0006 : MonoBehaviour
{
    private int toolbarIndex = 0;
    private string[] toolbarInfos = new string[] { "选项一", "选项二", "选项三" };

    private int selGridIndex = 0;

    private void OnGUI()
    {
        #region 工具栏

        toolbarIndex = GUI.Toolbar(new Rect(0, 0, 200, 30), toolbarIndex, toolbarInfos);

        switch (toolbarIndex)
        {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
        }

        #endregion

        #region 选择网格

        // 相对于Toolbar多了一个参数xCount 代表 水平方向最多的的按钮数量
        selGridIndex = GUI.SelectionGrid(new Rect(0, 60, 200, 60), selGridIndex, toolbarInfos, 2);

        switch (selGridIndex)
        {
            case 0:
                break; 
            case 1:
                break;
            case 2:
                break;
        }



        #endregion
    }
}

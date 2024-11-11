using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IM0010 : MonoBehaviour
{
    private void OnGUI()
    {
        #region 自动布局

        //主要用于编辑器开发，不合适做游戏UI
        //包裹使得横向绘制
        //GUILayout.BeginArea(new Rect(100,100,200,300));
        //GUI.BeginGroup(new Rect(100, 100, 200, 300)); // 配合GUI使用

        //GUILayout.BeginHorizontal();

        GUILayout.Button("123", GUILayout.Width(300));
        GUILayout.Button("456", GUILayout.ExpandWidth(false));
        GUILayout.Button("78910");

        //GUILayout.EndHorizontal();


        //GUI.EndGroup();
        //GUILayout.EndArea();

        #endregion

        #region GUILayoutOption 布局选项

        //控件的固定高
        GUILayout.Width(300);
        GUILayout.Height(200);
        //允许最小宽高
        GUILayout.MinWidth(50);
        GUILayout.MinHeight(50);
        //允许最大宽高
        GUILayout.MinHeight(100);
        GUILayout.MinHeight(100);
        //允许or禁止水平宽高扩展
        GUILayout.ExpandHeight(true);//允许
        GUILayout.ExpandWidth(false);//禁止

        #endregion
    }
}

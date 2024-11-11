using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class IM0008 : MonoBehaviour
{

    private void OnGUI()
    {
        #region 窗口

        // 第一个参数 id 是窗口的唯一ID 不要和别窗口重复
        // 委托函数 用于绘制窗口 的函数 传入即可
        GUI.Window(1, new Rect(100, 100, 200, 150), DrawWindow, "测试窗口1");
        // 窗口之间可以用一个 委托函数处理多个窗口 
        // 通过id区分
        GUI.Window(2, new Rect(100, 350, 200, 150), DrawWindow, "测试窗口2");

        #endregion

        #region 模态窗口

        // 模态窗口 可以让其他窗口不在有用
        // 可以理解为该窗口在最上层 其他按钮都点不到了
        // 只能点击该窗口的控件

        GUI.ModalWindow(3, new(300, 100, 200, 150), DrawWindow, "模态窗口");

        #endregion
    }

    private void DrawWindow(int id)
    {
        switch (id)
        {
            case 0:
                GUI.Button(new Rect(0, 30, 30, 20), "1");
                break;
            case 1:
                GUI.Button(new Rect(0, 30, 30, 20), "2");
                break;
            case 2:
                GUI.Button(new Rect(0, 30, 30, 20), "3");
                break;
            default:
                break;
        }

    }

}

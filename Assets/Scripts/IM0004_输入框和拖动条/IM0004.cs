using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IM0004 : MonoBehaviour
{
    private string inputStr = "请输入内容";

    private string inputPW = "请输入密码";

    private float inputFL = 0.5f;

    private void OnGUI()
    {
        #region 输入框

        #region 普通输入

        // 新参数 传递字符串 和 限制字数
        inputStr = GUI.TextField(new Rect(0, 0, 100, 30), inputStr, 5);

        #endregion

        #region 密码输入

        // 新参数 替换符
        inputPW = GUI.PasswordField(new Rect(0, 100, 100, 30), inputPW, '*',10);

        #endregion


        #endregion

        #region 拖动条

        #region 水平拖动条

        inputFL = GUI.HorizontalSlider(new Rect(0, 200, 100, 50), inputFL, 0.0f, 10.0f);
        Debug.Log(inputFL);

        #endregion

        #region 竖直拖动条

        inputFL = GUI.VerticalSlider(new Rect(0, 250, 50, 100), inputFL, 0.0f, 10.0f);

        #endregion

        #endregion
    }
}

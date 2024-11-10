using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IM0004 : MonoBehaviour
{
    private string inputStr = "请输入内容";

    private void OnGUI()
    {
        #region 输入框

        #region 普通输入

        inputStr = GUI.TextField(new Rect(0, 0, 100, 30), inputStr);

        #endregion

        #endregion
    }
}

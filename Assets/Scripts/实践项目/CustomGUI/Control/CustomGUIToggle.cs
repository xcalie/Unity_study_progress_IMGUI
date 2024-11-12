using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CustomGUIToggle : CustomGUIControl
{
    public bool isSel;

    public event UnityAction<bool> changeValue;

    private bool isOldSel;

    protected override void StyleOffDraw()
    {
        isSel = GUI.Toggle(guiPos.Pos, isSel, content);

        // 只有外部变化 才告诉执行函数 有必要执行 避免一直执行
        if (isOldSel != isSel)
        {
            changeValue?.Invoke(isSel);
            isOldSel = isSel;
        }
    }

    protected override void StyleOnDraw()
    {
        isSel = GUI.Toggle(guiPos.Pos, isSel, content, style);

        // 只有外部变化 才告诉执行函数 有必要执行 避免一直执行
        if (isOldSel != isSel )
        {
            changeValue?.Invoke(isSel);
            isOldSel = isSel;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CustomGUITextField : CustomGUIControl
{
    public event UnityAction<string> texChange;

    private string oldStr = "";


    protected override void StyleOffDraw()
    {
        content.text = GUI.TextField(guiPos.Pos, content.text);
        if (oldStr != content.text )
        {
            texChange?.Invoke(oldStr);
            oldStr = content.text;
        }
    }

    protected override void StyleOnDraw()
    {
        content.text = GUI.TextField(guiPos.Pos, content.text, style);
        if (oldStr != content.text)
        {
            texChange?.Invoke(oldStr);
            oldStr = content.text;
        }
    }
}

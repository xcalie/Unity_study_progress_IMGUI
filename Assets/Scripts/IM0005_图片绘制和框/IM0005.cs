using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IM0005 : MonoBehaviour
{
    public Rect texPos;

    public Texture tex;

    public ScaleMode mode = ScaleMode.StretchToFill;

    public bool alpha = true;

    public float wh = 0;

    private void OnGUI()
    {
        #region 图片绘制

        GUI.DrawTexture(texPos, tex, mode, alpha);

        #endregion

        #region 框绘制

        //GUI.Box(texPos, "");

        #endregion 
    }


}

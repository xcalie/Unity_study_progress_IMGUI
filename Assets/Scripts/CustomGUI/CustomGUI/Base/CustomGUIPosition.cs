using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

/// <summary>
/// 对其方式枚举
/// </summary>
public enum E_Alignment_Type
{
    Up,
    Down, 
    Left, 
    Right,
    Center,
    Left_Up,
    Left_Down,
    Right_Up,
    Right_Down,
}


//序列化后显示

/// <summary>
/// 该类 是用来表示位置 计算位置相关信息的 不需要继承mono
/// </summary>
[System.Serializable]
public class CustomGUIPosition
{
    //主要是处理 控件位置相关内容
    //要完成 分辨率自适应的相关计算
    //该位置信息 会返回给外部 用于绘制控件
    //需要对其计算
    // 控制坐标公式 = 相对屏幕位置 + 中心的偏移位置 + 偏移位置
    private Rect realPos = new Rect(0, 0, 100, 100);

    //屏幕九宫格对其的方式
    public E_Alignment_Type screen_Alignment_Type = E_Alignment_Type.Center;
    //控件中心对齐方式
    public E_Alignment_Type control_Center_Alignment_Type = E_Alignment_Type.Center;
    //偏移位置
    public Vector2 pos;
    //宽高
    public float width = 100;
    public float height = 50;


    // 用于计算中心点的成员变量
    private Vector2 centerPos;
    // 计算中心点偏移的方法
    private void CalculateCenterPos()
    {
        switch (control_Center_Alignment_Type)
        {
            case E_Alignment_Type.Up:
                centerPos.x = -width / 2;
                centerPos.y = 0;
                break;
            case E_Alignment_Type.Down:
                centerPos.x = -width / 2;
                centerPos.y = -height;
                break;
            case E_Alignment_Type.Left:
                centerPos.x = 0;
                centerPos.y = -height / 2;
                break;
            case E_Alignment_Type.Right:
                centerPos.x = -width;
                centerPos.y = -height / 2;
                break;
            case E_Alignment_Type.Center:
                centerPos.x = -width / 2;
                centerPos.y = -height / 2;
                break;
            case E_Alignment_Type.Left_Up:
                centerPos.x = 0;
                centerPos.y = 0;
                break;
            case E_Alignment_Type.Left_Down:
                centerPos.x = 0;
                centerPos.y = -height;
                break;
            case E_Alignment_Type.Right_Up:
                centerPos.x = -width;
                centerPos.y = 0;
                break;
            case E_Alignment_Type.Right_Down:
                centerPos.x = -width;
                centerPos.y = -height;
                break;
        }
    }

    // 计算最终相对坐标的方法
    private void CalculatePos()
    {
        switch (screen_Alignment_Type)
        {
            // -pos.y反转y轴
            // -pos.x反转x轴
            case E_Alignment_Type.Up:
                realPos.x = Screen.width / 2 + centerPos.x + pos.x;
                realPos.y = 0 + centerPos.y + pos.y;
                break;
            case E_Alignment_Type.Down:
                realPos.x = Screen.width / 2 + centerPos.x + pos.x;
                realPos.y = Screen.height + centerPos.y - pos.y;
                break;
            case E_Alignment_Type.Left:
                realPos.x = 0 + centerPos.x + pos.x;
                realPos.y = Screen.height / 2 + centerPos.y + pos.y;
                break;
            case E_Alignment_Type.Right:
                realPos.x = Screen.width + centerPos.x - pos.x;
                realPos.y = Screen.height / 2 + centerPos.y + pos.y;
                break;
            case E_Alignment_Type.Center:
                realPos.x = Screen.width / 2 + centerPos.x + pos.x;
                realPos.y = Screen.height / 2 + centerPos.y + pos.y;
                break;
            case E_Alignment_Type.Left_Up:
                realPos.x = 0 + centerPos.x + pos.x;
                realPos.y = 0 + centerPos.y + pos.y;
                break;
            case E_Alignment_Type.Left_Down:
                realPos.x = 0 + centerPos.x + pos.x;
                realPos.y = Screen.height + centerPos.y - pos.y;
                break;
            case E_Alignment_Type.Right_Up:
                realPos.x = Screen.width + centerPos.x - pos.x;
                realPos.y = 0 + centerPos.y + pos.y;
                break;
            case E_Alignment_Type.Right_Down:
                realPos.x = Screen.width + centerPos.x - pos.x;
                realPos.y = Screen.height + centerPos.y - pos.y;
                break;
        }
    }


    /// <summary>
    /// 得到最终绘制的位置和宽高
    /// </summary>
    public Rect Pos
    {
        get
        {
            //进行计算
            //计算中心点偏移
            CalculateCenterPos();
            //计算相对屏幕的坐标点
            CalculatePos();
            //宽高直接赋值返回给外部 直接用来绘制控件
            realPos.width = width;
            realPos.height = height;
            return realPos;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IM0001_Start : MonoBehaviour
{
    #region GUI 是什么

    //全称 即时模式游戏用户交互界面(IMGUI)
    //在Unity一般简称为GUI
    //他是代码驱动的UI系统   

    #endregion

    #region GUI的作用

    //作为程序员的主要调试工具，创建游戏内调试工具
    //为脚本组件自定义检视面板
    //创建新的编辑器窗口和工具以扩展Unity本身(一般内置游戏工具

    //不用做来玩家UI工具

    #endregion

    #region  GUI工作原理

    //在继承了Mono的脚本的特殊函数里
    //调用GUI提供的方法
    //类似生命周期函数
    private void OnGUI()
    {
        //在其中书写 GUI相关代码 即可显示GUI内容
    }
    // 它每帧执行相当于 专门用于绘制UI的函数
    // 一般只在其中执行GUI相关界面的操作逻辑
    // 该函数 在OnDisable 之前 LateUpdate之后执行
    // 只要是继承Mono的脚本 都可以在onGUI中绘制GUI

    #endregion
}

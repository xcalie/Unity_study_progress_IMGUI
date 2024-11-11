using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IM0003_execrcise : MonoBehaviour
{
    //面板的显示隐藏 所有的地方都能快速使用的
    //静态 方法 和 静态变量 可以直接通过类名使用

    private static IM0003_execrcise instance;

    public static void ShowMe()
    {
        if (instance != null)
        {
            instance.gameObject.SetActive(true);
        }
    }

    public static void HideMe()
    {
        if (instance != null)
        {
            instance.gameObject.SetActive(false);
        }
    }


    public Rect toggleMusicPos;
    public Rect toggleSoundPos;

    private bool isSelMusic = true;
    private bool isSelSound = true;

    public Rect btoPos;
    public GUIStyle Style;


    private float musicValue = 1;
    public Rect musicPos;

    private float soundValue = 1;
    public Rect soundPos;


    private void Awake()
    {
        instance = this;
        IM0003_execrcise.HideMe();
    }


    private void OnGUI()
    {
        isSelMusic = GUI.Toggle(toggleMusicPos, isSelMusic, "音乐开关");
        isSelSound = GUI.Toggle(toggleSoundPos, isSelSound, "音效开关");

        musicValue = GUI.HorizontalSlider(musicPos, musicValue, 0.0f, 1.0f);
        soundValue = GUI.HorizontalSlider(soundPos, soundValue, 0.0f, 1.0f);



        if (GUI.Button(btoPos, "", Style))
        {
            IM0003_execrcise.HideMe();
            IM0002_execrcise.ShowMe();
        }
    }
}

// 面板之间有3种方法 相互控制方法
// 1 都写在一个OnGUI中 通过bool表示去控制显示隐藏
// 2 挂载在同一对象向上 通过控制脚本的失活 来控制 enable 去控制代码是否执行
// 3 挂载在不同对象上 通过控制对象的失活激活 来达到 面板的显影

// 关键的 如何在多个面板之间相互调用显影 我们通过 静态变量和静态方法控制
//      在 Awake中 初始化 静态变量 如果要用该方法 一开始这个 对象不能失活

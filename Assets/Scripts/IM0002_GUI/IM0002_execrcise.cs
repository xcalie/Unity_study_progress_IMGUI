using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IM0002_execrcise : MonoBehaviour
{
    private static IM0002_execrcise instance;

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



    public Rect labPos;
    public GUIContent labContent;
    public GUIStyle labStyle;

    public Rect btn1Pos;
    public Rect btn2Pos;
    public Rect btn3Pos;

    public GUIStyle btnStyle;


    private void Awake()
    {
        instance = this;
    }


    private void OnGUI()
    {
        // 游戏标题
        GUI.Label(labPos, labContent, labStyle);

        // 3个游戏按钮
        if (GUI.Button(btn1Pos, "开始游戏", btnStyle))
        {
            SceneManager.LoadScene("GameScene");
        }
        if (GUI.Button(btn2Pos, "设置游戏", btnStyle))
        {
            IM0003_execrcise.ShowMe();
            IM0002_execrcise.HideMe();
        }
        if (GUI.Button(btn3Pos, "退出游戏", btnStyle))
        {

        }
    }
}

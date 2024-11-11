using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IM0004_execrcise : MonoBehaviour
{
    private static IM0004_execrcise instance;

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

    private void Awake()
    {
        instance = this;
        IM0004_execrcise.HideMe();
    }


    // 按钮
    public Rect btn1Pos;
    public Rect btn2Pos;

    // Label
    public Rect lab1Pos;
    public Rect lab2Pos;

    // 输入框
    private string userName = "";
    public Rect input1Pos;

    private string password = "";
    public Rect input2Pos;


    public Rect bkPos;
    public Texture bkTes;


    private void OnGUI()
    {
        GUI.DrawTexture(bkPos, bkTes);  


        // 按钮
        if (GUI.Button(btn1Pos, "登陆游戏"))
        {
            if (userName == "admin" && password == "8888" )
            {
                SceneManager.LoadScene("GameScene");
            }
            else
            {
                Debug.Log("用户名或者密码错误");
            }
        }
        if (GUI.Button(btn2Pos, "返回"))
        {
            IM0004_execrcise.HideMe();
            IM0002_execrcise.ShowMe();
        }

        // 文本
        GUI.Label(lab1Pos, "用户名");
        GUI.Label(lab2Pos, "密码");

        // 输入框
        userName = GUI.TextField(input1Pos, userName);
        password = GUI.PasswordField(input2Pos, password, '*');
    }
}

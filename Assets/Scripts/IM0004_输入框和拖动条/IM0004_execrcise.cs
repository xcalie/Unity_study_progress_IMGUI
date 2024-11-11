using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IM0004_execrcise : MonoBehaviour
{
    // 按钮
    public Rect btn1Pos;
    public Rect btn2Pos;

    // Label
    public Rect lab1Pos;
    public Rect lab2Pos;

    // 输入框
    private string userName;
    public Rect input1Pos;

    private string password;
    public Rect input2Pos;



    private void OnGUI()
    {
        // 按钮
        if (GUI.Button(btn1Pos, "登陆游戏"))
        {
            if (userName == "admin" && password == "8888")
            {
                SceneManager.LoadScene("GameSecne");

            }
            else
            {
                Debug.Log("用户名或者密码错误");

            }
        }
        if (GUI.Button(btn2Pos, "返回"))
        {

        }
        // 文本
        GUI.Label(lab1Pos, "用户名");
        GUI.Label(lab2Pos, "密码");

        // 输入框
        userName = GUI.TextField(input1Pos, userName);
        password = GUI.TextField(input2Pos, password);
    }
}

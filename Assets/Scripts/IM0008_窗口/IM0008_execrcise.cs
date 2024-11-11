using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IM0008_execrcise : MonoBehaviour
{
    private static IM0008_execrcise instance;

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
        IM0008_execrcise.HideMe();
    }

    public Rect winPos;

    public Rect labPos;
    public Rect btnPos1;
    public Rect btnPos2;

    private void OnGUI()
    {
        GUI.ModalWindow(1, winPos, DrawWindow, "提示");

    }

    private void DrawWindow(int id)
    {
        GUI.Label(labPos,"是否退出");

        if (GUI.Button(btnPos1, "退出"))
        {
            Application.Quit();
        }

        if (GUI.Button(btnPos2, "取消"))
        {
            IM0008_execrcise.HideMe();
            IM0002_execrcise.ShowMe();
        }
    }
}

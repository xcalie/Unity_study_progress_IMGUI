using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CustomGUIToggleGroup : MonoBehaviour
{
    public CustomGUIToggle[] toggles;

    // 上一次为true的toggle
    private CustomGUIToggle frontTureToggle;

    private void Start()
    {
        if (toggles.Length == 0)
            return;

        // 通过遍历 来为多个 多选框 添加监听事件函数
        // 在函数中做处理
        // 当一个为true时 另外两个做处理
        for (int i = 0; i < toggles.Length; i++)
        {
            CustomGUIToggle toggle = toggles[i];
            toggle.changeValue += (value) =>
            {
                // 当传入 value 是 true 时 需要把另外两个 保持false
                if (value)
                {
                    // 意味着另外几个要变为false
                    for (int j = 0; j < toggles.Length; j++)
                    {
                        //这里有闭包 toggle 就是上一个函数中的申明的变量
                        //改变了它的生命周期
                        if (toggles[j] != toggle)
                        {
                            toggles[j].isSel = false;
                        }
                    }

                    //记录上一次为true的toggle
                    frontTureToggle = toggle;
                }
                // 来判断 当前变成false的toggle是不是上一次为true的toggle
                // 如果是则强制变成true形成单选框的设置
                else if (toggle == frontTureToggle)
                {
                    //强制改变
                    toggle.isSel = true;
                }
            };
        }
    }
}

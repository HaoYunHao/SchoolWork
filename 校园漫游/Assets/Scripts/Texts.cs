using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Texts : MonoBehaviour
{
    public GameObject SchoolObject; // 触发器范围所在的游戏对象
    public GameObject Txt; // 需要显示的文本提示信息的游戏对象
    private bool IsStay = true; // 标记是否需要显示文本提示信息

    void Start()
    {
        Txt.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        // 判断是否为玩家对象，并且当前处于需要显示文本提示信息的状态
        if (other.gameObject.tag == "Player" && IsStay == true)
        {
            Txt.SetActive(true); // 显示文本提示信息
            if (Input.GetKeyDown(KeyCode.E))
            {
                Txt.SetActive(false); // 隐藏文本提示信息
                IsStay = false; // 设置为不需要显示文本提示信息的状态
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Txt.SetActive(false); // 离开触发器后隐藏文本提示信息
        }
    }

    void Update()
    {

    }
}
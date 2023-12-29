using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RayTest : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public string roomName; // 房间的名称
    public Text roomNameText; // 用于显示房间名称的UI Text组件

    private void Start()
    {
        roomNameText.gameObject.SetActive(false); // 初始状态下隐藏房间名称
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        roomNameText.text = roomName; // 设置UI Text的文本为当前房间的名称
        roomNameText.gameObject.SetActive(true); // 显示房间名称
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        roomNameText.gameObject.SetActive(false); // 隐藏房间名称
    }
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity))
        {
            if (hitInfo.collider.gameObject == gameObject)
            {
                Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto); // 可选：将鼠标指针设置为默认
            }
        }
    }
}
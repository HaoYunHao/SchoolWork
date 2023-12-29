//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using Valve.VR;

//public class KeyMonitor : MonoBehaviour
//{
//    public SteamVR_Input_Sources handType; // 左手或右手
//    public SteamVR_Action_Boolean triggerAction; // 扳机按下事件
//    public SteamVR_Action_Vector2 touchpadAction; // 传送事件（摇杆位置）
//    public SteamVR_Action_Boolean primaryButtonAction; // 主要按钮事件
//    public SteamVR_Action_Boolean secondaryButtonAction; // 次要按钮事件

//    private void Update()
//    {
//        if (triggerAction.GetStateDown(handType))
//        {
//            float triggerValue = triggerAction.GetState(handType).magnitude; // 扳机按键深度
//            Debug.Log("Trigger Pressed! Depth: " + triggerValue);
//        }

//        if (touchpadAction.GetChanged(handType))
//        {
//            Vector2 touchpadPosition = touchpadAction.GetAxis(handType); // 摇杆位置
//            Debug.Log("Touchpad Position: " + touchpadPosition);
//        }

//        if (primaryButtonAction.GetStateDown(handType))
//        {
//            Debug.Log("Primary Button Pressed!");
//        }

//        if (secondaryButtonAction.GetStateDown(handType))
//        {
//            Debug.Log("Secondary Button Pressed!");
//        }
//    }
//}

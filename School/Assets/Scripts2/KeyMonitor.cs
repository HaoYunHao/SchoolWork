//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using Valve.VR;

//public class KeyMonitor : MonoBehaviour
//{
//    public SteamVR_Input_Sources handType; // ���ֻ�����
//    public SteamVR_Action_Boolean triggerAction; // ��������¼�
//    public SteamVR_Action_Vector2 touchpadAction; // �����¼���ҡ��λ�ã�
//    public SteamVR_Action_Boolean primaryButtonAction; // ��Ҫ��ť�¼�
//    public SteamVR_Action_Boolean secondaryButtonAction; // ��Ҫ��ť�¼�

//    private void Update()
//    {
//        if (triggerAction.GetStateDown(handType))
//        {
//            float triggerValue = triggerAction.GetState(handType).magnitude; // ����������
//            Debug.Log("Trigger Pressed! Depth: " + triggerValue);
//        }

//        if (touchpadAction.GetChanged(handType))
//        {
//            Vector2 touchpadPosition = touchpadAction.GetAxis(handType); // ҡ��λ��
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

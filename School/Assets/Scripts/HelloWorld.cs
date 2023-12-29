//using System;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEditor.VersionControl;
//using UnityEngine;
//using Valve.VR;

//public class HelloWorld : MonoBehaviour
//{
//    // Start is called before the first frame update
//    void Start()
//    {
//        SteamVR_Actions.default_InteractUI.onStateDown += OnStateDown;
//        SteamVR_Actions.default_GrabGrip.onStateDown += OnStateDown;
//        SteamVR_Actions.default_HeadsetOnHead.onStateDown += OnStateDown;
//        SteamVR_Actions.default_Teleport.onStateDown += OnStateDown;
//        //SteamVR_Actions.default__001.onStateDown += OnStateDown;

//        SteamVR_Actions.platformer_Jump.onStateDown += OnStateDown;
//        SteamVR_Actions.buggy_Reset.onStateDown += OnStateDown;

//    }

//    private void OnDestroy()
//    {
//        SteamVR_Actions.default_InteractUI.onStateDown -= OnStateDown;
//        SteamVR_Actions.default_GrabGrip.onStateDown -= OnStateDown;
//        SteamVR_Actions.default_HeadsetOnHead.onStateDown -= OnStateDown;
//        SteamVR_Actions.default_Teleport.onStateDown -= OnStateDown;
//        //SteamVR_Actions.default__001.onStateDown -= OnStateDown;

//        SteamVR_Actions.platformer_Jump.onStateDown -= OnStateDown;
//        SteamVR_Actions.buggy_Reset.onStateDown -= OnStateDown;
//    }
//    private void OnStateDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
//    {
//        print($"{fromAction.activeDevice},{fromSource}");
//    }

//    // Update is called once per frame
//    void Update()
//    {
        
//    }
//}

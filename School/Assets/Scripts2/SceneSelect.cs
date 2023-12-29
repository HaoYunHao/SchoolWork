using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSelect : MonoBehaviour
{
    public GameObject pcScene; // PC端场景
    public GameObject vrScene; // VR端场景

    private void Awake()
    {
        ConfigManager configManager = GetComponent<ConfigManager>();

        if (configManager.isVR)
        {
            //加载VR端场景
            Instantiate(vrScene);
        }
        else
        {
            //加载PC端场景
            Instantiate(pcScene);
        }

        //销毁当前场景
        Destroy(gameObject);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ConfigManager : MonoBehaviour
{
    public bool isVR; // 判断是否为VR端

    private void Awake()
    {
        LoadConfig();
    }

    // 加载config.json文件
    private void LoadConfig()
    {
        string filePath = Application.streamingAssetsPath + "/config.json";

        if (File.Exists(filePath))
        {
            string data = File.ReadAllText(filePath);
            ConfigData config = JsonUtility.FromJson<ConfigData>(data);
            isVR = config.isVR;
        }
        else
        {
            // 如果config.json文件不存在，则创建一个默认的config.json文件
            CreateDefaultConfig();
        }
    }

    // 创建默认的config.json文件
    private void CreateDefaultConfig()
    {
        ConfigData defaultConfig = new ConfigData();
        defaultConfig.isVR = false; // 默认为PC端

        string filePath = Application.streamingAssetsPath + "/config.json";
        string jsonData = JsonUtility.ToJson(defaultConfig);

        File.WriteAllText(filePath, jsonData);
    }
}

// config.json数据结构
[System.Serializable]
public class ConfigData
{
    public bool isVR;
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ConfigManager : MonoBehaviour
{
    public bool isVR; // �ж��Ƿ�ΪVR��

    private void Awake()
    {
        LoadConfig();
    }

    // ����config.json�ļ�
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
            // ���config.json�ļ������ڣ��򴴽�һ��Ĭ�ϵ�config.json�ļ�
            CreateDefaultConfig();
        }
    }

    // ����Ĭ�ϵ�config.json�ļ�
    private void CreateDefaultConfig()
    {
        ConfigData defaultConfig = new ConfigData();
        defaultConfig.isVR = false; // Ĭ��ΪPC��

        string filePath = Application.streamingAssetsPath + "/config.json";
        string jsonData = JsonUtility.ToJson(defaultConfig);

        File.WriteAllText(filePath, jsonData);
    }
}

// config.json���ݽṹ
[System.Serializable]
public class ConfigData
{
    public bool isVR;
}
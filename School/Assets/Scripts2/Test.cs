//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using Newtonsoft.Json;
//using System;
//using System.IO;
//using LitJson;
//using UnityEditor;

//public class PlayerData
//{
//    public int ID;
//    public string PassWord;
//    public float[] Position;
//    public float[] Rotation;
//}
//public class Test : MonoBehaviour
//{
//    public static Test Instance;
//    public GameObject Player;

//    void Start()
//    {
//        Instance = GetComponent<Test>();
//        Player = GameObject.Find("AcquireChan");
//    }
//    public void InitPlayer(PlayerData data)
//    {
//        if (Player == null)
//        {
//            return;
//        }
//        Player.transform.position = new Vector3 (data.Position [0], data.Position[1], data.Position[2]);
//        Player.transform.eulerAngles = new Vector3(data.Rotation[0], data.Rotation[1], data.Rotation[2]);
//    }
//    private void OnApplicationQuit()
//    {
//        SavePlayerData();
//        }
//    void SavePlayerData()
//    {
//        if (Player == null)
//        {
//            return;
//        }
//        PlayerData data = new PlayerData();
//        data.ID = LoginPanel.instance.ID;
//        data.PassWord = LoginPanel.instance.PassWord;
//        float[] position = new float[] { Player.transform.position.x, Player.transform.position.y, Player.transform.position.z };
//        data.Position = position;
//        float[] rotation = new float[] { Player.transform.eulerAngles.x, Player.transform.eulerAngles.y, Player.transform.eulerAngles.z };
//        data.Rotation = rotation;

//        var json = JsonMapper.ToJson(data);

//        string path = Application.dataPath + DataManager.PlayerDataJSONFileName;
//        //File.WriteAllTextAsync(path, json);

//    }
//    // Start is called before the first frame update
    
    
//    // Update is called once per frame
//    void Update()
//    {
        
//    }
//}

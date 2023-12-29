//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using Newtonsoft.Json;
//using System;
//using System.IO;
//using LitJson;

//public class LoginPanel : MonoBehaviour
//{
//    public static LoginPanel instance;
//    public InputField UserIDInputField;
//    public InputField PassWordInputField;
//    public Button LoginButton;

//    public int ID;
//    public string PassWord;
//    // Start is called before the first frame update
//    void Start()
//    {
//        instance = transform .GetComponent <LoginPanel>();
//        string playerDataPath = Application.dataPath + DataManager.PlayerDataJSONFileName;
//        if(System.IO.File.Exists(playerDataPath))
//        {
//            LoadPlayerData(playerDataPath);
//            gameObject.SetActive(false);
//            return;
//        }
//        UserIDInputField = transform.Find("UserIDInputField").GetComponent<InputField>();
//        PassWordInputField = transform.Find("PassWordInputField").GetComponent<InputField>();
//        LoginButton = transform.Find("LoginButton").GetComponent<Button>();
//        LoginButton.onClick.AddListener(Login);
//    }
//    void LoadPlayerData(string path)
//    {
//        var json = File.ReadAllText(path);
//        var playerData = JsonMapper.ToObject<PlayerData>(json);
//        Test.Instance.InitPlayer(playerData);
//    }
//    void Login()
//    {
//        if (string.Equals(UserIDInputField.text, string.Empty) || string.Equals(PassWordInputField.text, string.Empty))
//        {
//            Debug.Log("缺少数据");
//            return;
//        }
//        ID = int.Parse(UserIDInputField.text);
//        PassWord = PassWordInputField.text;
//        gameObject.SetActive(false);
//    }
//    // Update is called once per frame
//    void Update()
//    {

//    }
//}

using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UILogin : MonoBehaviour
{
    public GameObject registerPanel;
    public GameObject loginPanel;
    public InputField userID;//登录学号
    public InputField passWord;//登录密码
    public InputField r_userID;//注册学号
    public InputField r_passWord;//注册密码
    public InputField cr_passWord;//确认密码
    string NewID;
    string pass;
    // Start is called before the first frame update
    void Start()
    {
   
    }
    public void ConfirmRegister()
    {
        NewID = r_userID.text;//临时存储注册学号
        pass = r_passWord.text;//临时存储注册密码
        if (!string.IsNullOrEmpty(NewID) && !string.IsNullOrEmpty(pass) && pass == cr_passWord.text)
        {
            print("注册成功");
            registerPanel.SetActive(true);
        }
        else
        {
            print("注册失败");
            NewID = "";
            pass = "";
        }
        r_userID.text = "";
        r_passWord.text = "";
        cr_passWord.text = "";

    }
    public void Login()
    {
        if (!string.IsNullOrEmpty(NewID) && userID.text == NewID && passWord.text == pass)
        {
            print("登录成功");
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
        else
        {
            print("登录失败");
        }
        userID.text = "";
        passWord.text = "";
    }
    public void OpenRegisterPanel()
    {
        registerPanel.SetActive(true);
        loginPanel.SetActive(false);
    }
    public void CloseRegisterPanel()
    {
        registerPanel.SetActive(false);
        loginPanel.SetActive(true);
    }

}
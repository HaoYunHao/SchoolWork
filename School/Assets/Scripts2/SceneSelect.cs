using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSelect : MonoBehaviour
{
    public GameObject pcScene; // PC�˳���
    public GameObject vrScene; // VR�˳���

    private void Awake()
    {
        ConfigManager configManager = GetComponent<ConfigManager>();

        if (configManager.isVR)
        {
            //����VR�˳���
            Instantiate(vrScene);
        }
        else
        {
            //����PC�˳���
            Instantiate(pcScene);
        }

        //���ٵ�ǰ����
        Destroy(gameObject);
    }
}
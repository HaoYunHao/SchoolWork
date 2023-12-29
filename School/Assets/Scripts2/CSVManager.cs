//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using System.Data;
//using System.IO;
//using System;

//public class CSVManager : MonoBehaviour
//{
//    public DataTable LoadCSV()
//    {
//        DataTable dataTable = new DataTable();
//        string path = Application.dataPath + DataManager.PlayerDataCSVFileName;
//        string csvString = File.ReadAllText(path);

//        //使用变量定义分隔符
//        //当需要更换分割符号时，不需要手动更改
//        string lineFeedSign = ",";


//        List<Type> dataTypes = new List<Type>();
//        for(int i = 0; i < csvRowDatas.Length; i++)
//        {
//            string[] csvRowDatas = csvRowDatas[i].Split(separateSign);

//        }

//    }
//    private void SaveCSV()
//    {
//        DataTable dataTable = new DataTable("PlayerPropertyData");

//        // 创建表头
//        dataTable.Columns.Add("等级");
//        dataTable.Columns.Add("力量");
//        dataTable.Columns.Add("移动速度");

//        // 保存十行数据
//        for (int i = 0; i < 10; i++)
//        {
//            DataRow dataRow = dataTable.NewRow();
//            dataRow["等级"] = i;
//            dataRow["力量"] = 10*(i+1);
//            dataRow["力量"] = i * 1.13f;
//            // 将行添加到表中
//            dataTable.Rows.Add(dataRow);
//        }

//        // 将数据保存到CSV文件
//        SaveDataTableToCSV(dataTable, "PlayerPropertyData");
//    }


//    private void SaveDataTableToCSV(DataTable dataTable, string fileName)
//    {
//        // 创建CSV文件路径
//        string filePath = Application.dataPath + "/Resources/" + fileName + ".csv";

//        // 写入CSV文件
//        using (StreamWriter writer = new StreamWriter(filePath))
//        {
//            // 写入表头
//            for (int i = 0; i < dataTable.Columns.Count; i++)
//            {
//                writer.Write(dataTable.Columns[i]);
//                if (i < dataTable.Columns.Count - 1)
//                {
//                    writer.Write(",");
//                }
//            }
//            writer.WriteLine();

//            // 写入数据行
//            foreach (DataRow row in dataTable.Rows)
//            {
//                for (int i = 0; i < dataTable.Columns.Count; i++)
//                {
//                    writer.Write(row[i]);
//                    if (i < dataTable.Columns.Count - 1) a
//                    {
//                        writer.Write(",");
//                    }
//                }
//                writer.WriteLine();
//            }
//        }
//    }
//}

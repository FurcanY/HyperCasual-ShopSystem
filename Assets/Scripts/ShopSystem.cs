using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Data.SqlTypes;
using System.Reflection;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using System.Runtime.CompilerServices;

public class ShopSystem : MonoBehaviour
{


    private string filePath;
    public Skins skinler = new Skins();
    public Button[] Buttons;
    private int para;
    private int select_index;
    private void Awake()
    {
        
        
        para = PlayerPrefs.GetInt("para");
        select_index = PlayerPrefs.GetInt("select_index");
        // JSON dosyasýnýn kaydedileceði konumu belirtin
        filePath = Application.persistentDataPath + "/data.json";
    
    }

    private void Start()
    {
        

        if (File.Exists(filePath))
        {
            skinler = LoadData();
            Debug.Log("veriler esitlendi");
        }
        else
        {
            Debug.Log("Veri Bulunamadi");
        }
        UIGuncelle();


    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.S)) {
            SaveData(skinler);
        }
    }
    public void SaveData(Skins data)
    {
        
        string jsonData = JsonUtility.ToJson(data,true);
        Debug.Log(jsonData);
        File.WriteAllText(filePath, jsonData);
        
    }

    public Skins LoadData()
    {
        Skins skinData = new Skins();

        if (File.Exists(filePath))
        {
            // JSON dosyasýný okuma
            string jsonData = File.ReadAllText(filePath);
            skinData = JsonUtility.FromJson<Skins>(jsonData);
        }

        return skinData;
    }

    public void SatinAl()
    {
        List<SkinData> lockedSkins = new List<SkinData>();
        for (int i = 0; i < skinler.items.Count; i++)
        {
            if (skinler.items[i].AcikMi == false)
            {
                lockedSkins.Add(skinler.items[i]);
            }
        }
        int acilmaSayisi = skinler.items.Count - lockedSkins.Count;
        if (acilmaSayisi * 100 <= PlayerPrefs.GetInt("para") && acilmaSayisi!=skinler.items.Count)
        {
            lockedSkins[Random.Range(0, lockedSkins.Count)].AcikMi = true;
            PlayerPrefs.SetInt("para",PlayerPrefs.GetInt("para") - acilmaSayisi * 100);
            
            SaveData(skinler);
            UIGuncelle();
        }
        else
        {
            Debug.Log("Satin alinma gerceklestirilemedi");
        }


    }
    public void Sec(int index)
    {
        select_index = index;
        PlayerPrefs.SetInt("select_index", select_index);
        Debug.Log("selected index :" + select_index);
    }
    public void UIGuncelle()
    {
        for (int i = 0; i < skinler.items.Count; i++)
        {
            if (skinler.items[i].AcikMi == true)
            {
                Buttons[i].interactable = true;
            }
        }
    }
}

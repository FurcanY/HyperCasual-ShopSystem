using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class UIGuncelle : MonoBehaviour
{
    private TMP_Text para_Text;
    private void Awake()
    {
     para_Text=GameObject.Find("para_text").GetComponent<TMP_Text>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        para_Text.text ="Para :"+ PlayerPrefs.GetInt("para").ToString();
    }
}

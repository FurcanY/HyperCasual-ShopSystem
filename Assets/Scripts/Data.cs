using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Data : MonoBehaviour
{
    

}


[System.Serializable]
public class Skins
{
    public List<SkinData> items=new List<SkinData>();
}

[System.Serializable]
public class SkinData
{
    public bool AcikMi;

    public SkinData()
    {

    }
    public SkinData(bool acikMi)//constructor
    {
        AcikMi = acikMi;
    }
}

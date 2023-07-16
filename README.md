# :collision: Hyper Casual Shop System :sparkles: :fire:


## :grey_exclamation: Bu projemde Hyper Casual oyunlarda sık karşılaştığımız, rastgele olarak skin açma shop sistemini yaptım. :grey_exclamation:

<img src="https://media.giphy.com/media/v1.Y2lkPTc5MGI3NjExeXRvMnZvZjltcnlnZHBlN2p0Y2MxMDlvbndla2d4cXAyOTdoOXJ0OCZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9Zw/ikW91tb9WKB9Rmf44L/giphy.gif" width="640" height="360" />

![OyunIciGoruntu1](https://github.com/FurcanY/HyperCasual-ShopSystem/assets/114299899/706955e5-82b7-42d9-ad56-f879a6936537)
![OyunIciGoruntu2](https://github.com/FurcanY/HyperCasual-ShopSystem/assets/114299899/cbb79a0e-f2e7-44e4-b4ac-1ccf09cd2e66)


### Bu projeyi yapmamdaki nedenlerim:
#### :point_right: Json ile Unity icerisindeki istedigimiz verileri kaydetmeyi ogrenmek.
#### :point_right: Json ile Unity icerisindeki istedigimiz verileri oyun icerisinde cagirmayi ogrenmek.
#### :point_right: Unity icerisinde istedigimiz class'i olusturup onunla islemler yapmayi ogrenmek.
#### :point_right: Unity arayuzu ile verileri eslestirmeyi ogrenmek.
#### :point_right: Sahneler arasi veri gecisini PlayerPrefs ile yapmak.

## Proje İçinden Örnek Kodlar 💾

## Data.cs icerisinden kodlar:
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
## ShopSystem.cs icerisinden kodlar:

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
            // JSON dosyas�n� okuma
            string jsonData = File.ReadAllText(filePath);
            skinData = JsonUtility.FromJson<Skins>(jsonData);
        }

        return skinData;
    }

        
        
   ## :rose: Belki Bakarsın Diye Bırakıyorum :rose:
   ####  GitHub adresime [buradan](https://github.com/FurcanY) ulaşabilirsiniz.
   ####  İnstagram adresime [buradan](https://www.instagram.com/y.furcan/) ulaşabilirsiniz.
   ####  Youtube adresime [buradan](https://www.youtube.com/channel/UCQRXjt0lg2jCnp2NqOAO2Ig) ulaşabilirsiniz.
   ####  Itch.io adresime [buradan](https://furcany.itch.io/) ulaşabilirsiniz.
   


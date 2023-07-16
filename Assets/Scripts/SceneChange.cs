using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void SahneGec(int sahneIndex)
    {
        SceneManager.LoadScene(sahneIndex);
    }
    public void ParaArttir()
    {
        PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") + 100);
        Debug.Log("Para arttirildi !");
    }

}

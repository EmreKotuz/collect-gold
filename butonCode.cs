using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class butonCode : MonoBehaviour
{
public void levelIki()
    {
        SceneManager.LoadScene("levelIki");
    }
    public void menuler()
    {
        SceneManager.LoadScene("levelMenu");
    }
    public void digerOyunlar()
    {
        Application.OpenURL("https://play.google.com/store/apps/dev?id=5935531608885806172");
    }
    public void levelBesss()
    {
        SceneManager.LoadScene("5");
        int sonrakiLevel = int.Parse(Application.loadedLevelName) + 1;
        PlayerPrefs.SetInt(sonrakiLevel.ToString(), 1);
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class bolumlevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.name == "1")
        {
            GetComponent<Button>().interactable = true;
        }
        else
        {
            if (PlayerPrefs.GetInt(gameObject.name) == 0)
            {
                GetComponent<Button>().interactable = false;
            }
            else
            {
                GetComponent<Button>().interactable = true;
            }
        }
        
    }
    public void levelBir()
    {
        SceneManager.LoadScene("1");
    }
    public void levelIki()
    {
        SceneManager.LoadScene("2");
    }
    public void levelUc()
    {
        SceneManager.LoadScene("3");
    }
    public void levelDort()
    {
        SceneManager.LoadScene("4");
    }
    public void levelBes()
    {
        SceneManager.LoadScene("5");
    }
    public void levelAlti()
    {
        SceneManager.LoadScene("6");
    }
    public void levelYedi()
    {
        SceneManager.LoadScene("7");
    }
    public void levelSekiz()
    {
        SceneManager.LoadScene("8");
    }
    public void levelOn()
    {
        SceneManager.LoadScene("10");
    }
    public void digerLevelGecis()
    {
        SceneManager.LoadScene("levelIki");       
    }
    public void levelOnBir()
    {
        SceneManager.LoadScene("11");
    }
    public void levelOnIki()
    {
        SceneManager.LoadScene("12");
    }
    public void levelOnUc()
    {
        SceneManager.LoadScene("13");
    }
}

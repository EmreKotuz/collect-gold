using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class hareket : MonoBehaviour
{
    public bool sagaGidiyor, solaGidiyor;
    public int KarakterHizi;
    public Rigidbody2D rigidbady;
    public int ziplamaHizi;
    public bool ziplaa;
    public GameObject bittiPanel;
    public GameObject baslaPanel;
    public TextMeshProUGUI yazi;
    public TextMeshProUGUI money;
    public float para=0;
    public GameObject solButton;
    public GameObject sagbutton;
    public GameObject ziplaButton;
    public TextMeshProUGUI kalanPara;
    public float kPara = 6000f;
    public GameObject jumpp;
    public GameObject speeed;
    public GameObject ttime;
    public GameObject dükkan;
    public float saghiz = 44700f;
    public float solhiz = 43700f;
    public TextMeshProUGUI zaman;
    public float saniye = 100f;
    public GameObject nextPanel;
    public Sprite kirmizit;
    public Sprite dil;
    public Sprite mavit;
    public Sprite turuncut;
    public Sprite morit;
    public Sprite pembet;
    public GameObject baslaPanelx;
    public GameObject jumpA;
    public GameObject spedA;
    public GameObject timeA;
    public GameObject düstüPanel;

    private void Start()
    {
        Time.timeScale = 0.0f;
        baslaPanel.SetActive(true);
        solButton.SetActive(false);
        sagbutton.SetActive(false);
        ziplaButton.SetActive(false);
        dükkan.SetActive(false);
       
    }//Remaining Money: 6000 TL
    private void Update()
    {
        
        if (Time.timeScale == 1.0f)
        {
            saniye -= Time.deltaTime;
            zaman.text = "Time: " + saniye.ToString("f");
            dükkan.SetActive(true);            
        }
        else
        {
            dükkan.SetActive(false);

        }
        if (saniye <= 0)
        {
            zaman.text = "GAME OVER";
            Time.timeScale = 0.0f;
            bittiPanel.SetActive(true);
        }

        
    }
    private void FixedUpdate()
    {
        if (sagaGidiyor)
        {
            float horizontalUpdate =+saghiz * Time.deltaTime;
            Harekett(horizontalUpdate);
        }
        if (solaGidiyor)
        {
            float horizontalUpdate =-solhiz * Time.deltaTime;
            Harekett(horizontalUpdate);
        }
    }
    public void Harekett(float Horizontal)
    {
        float horizontall=Horizontal;
        Vector3 charterNewPos = new Vector3(horizontall, rigidbady.velocity.y, 0);
        rigidbady.velocity = charterNewPos;
    }
  
    public void sagTikla()
    {
        sagaGidiyor = true;
    }
    public void sagTiklaBirak()
    {
        sagaGidiyor = false;
        Harekett(0);
    }
    public void solTikla()
    {
        solaGidiyor = true;
        Debug.Log("tiklandi");
    }
    public void solTiklaBirak()
    {
        solaGidiyor = false;
        Debug.Log("birakti");
        Harekett(0);
    }
    public void zipla()
    {
            if (!ziplaa)
            {
                rigidbady.AddForce(new Vector2(0, ziplamaHizi));
                Debug.Log("tiklandiii");            
        }        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "zemin")
        {
            ziplaa = false;
        }
        if (collision.tag == "bitti")
        {
            Time.timeScale = 0.0f;
            bittiPanel.SetActive(true);
            //yazi.text = "Great! " + para.ToString();
        }
        if (collision.tag == "dustu")
        {
            Time.timeScale = 0.0f;
            düstüPanel.SetActive(true);
        }
        if (collision.tag == "altin")
        {
            Destroy(collision.gameObject);
            para = para + 150;
            money.text = "GOLD : " + para.ToString();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "zemin")
        {
            ziplaa = true;
        }//<>
    }
    public void jumpAltin()
    {
        if(para >= 2000)
        {
            para = para - 2000;
            money.text = "Gold : " + para.ToString();
            ziplamaHizi = ziplamaHizi + 25000;
            Destroy(jumpA);
        }
    }
    public void speedAltin()
    {
        if (para >= 3400)
        {
            para = para - 3400;
            money.text = "Gold : " + para.ToString();
            saghiz = saghiz + 1200;
            solhiz = solhiz + 800;
            Destroy(spedA);
        }
    }
    public void timeAltin()
    {
        if (para >= 2400)
        {
            para = para - 2400;
            money.text = "Gold : " + para.ToString();
            saniye = saniye + 30;
            zaman.text = "Time: " + saniye.ToString("f");
            Destroy(timeA);
        }
    }
    public void timeAltinIki()
    {
        if (para >= 2400)
        {
            para = para - 2400;
            money.text = "Gold : " + para.ToString();
            //süreBaslaa = süreBaslaa - 30;
            //sürezamaen.text = "Time: " + süreBaslaa.ToString("f");
            //Destroy(timeA);
        }
    }
    public void returnn()
    {
        SceneManager.LoadScene("1");
    }
    public void levelIIIki()
    {
        SceneManager.LoadScene("levelIki");
    }
    public void levelIkiYeniden()
    {
        SceneManager.LoadScene("levelIki");
    }
    public void levelIki()
    {
        SceneManager.LoadScene("1");
    }
    public void next()
    {
        baslaPanel.SetActive(false);
        nextPanel.SetActive(true);

    }//
    public void kirmizi()
    {
        GameObject top = GameObject.Find("top");
        top.GetComponent<SpriteRenderer>().sprite = kirmizit;
        nextPanel.SetActive(false);
        Time.timeScale = 1.0f;
        solButton.SetActive(true);
        sagbutton.SetActive(true);
        ziplaButton.SetActive(true);

    }
    public void morr()
    {
        GameObject top = GameObject.Find("top");
        top.GetComponent<SpriteRenderer>().sprite = morit;
        nextPanel.SetActive(false);
        Time.timeScale = 1.0f;
        solButton.SetActive(true);
        sagbutton.SetActive(true);
        ziplaButton.SetActive(true);

    }
    public void pembe()
    {
        GameObject top = GameObject.Find("top");
        top.GetComponent<SpriteRenderer>().sprite = pembet;
        nextPanel.SetActive(false);
        Time.timeScale = 1.0f;
        solButton.SetActive(true);
        sagbutton.SetActive(true);
        ziplaButton.SetActive(true);

    }
    public void turuncu()
    {
        GameObject top = GameObject.Find("top");
        top.GetComponent<SpriteRenderer>().sprite = turuncut;
        nextPanel.SetActive(false);
        Time.timeScale = 1.0f;
        solButton.SetActive(true);
        sagbutton.SetActive(true);
        ziplaButton.SetActive(true);

    }
    public void mavi()
    {
        GameObject top = GameObject.Find("top");
        top.GetComponent<SpriteRenderer>().sprite = mavit;
        nextPanel.SetActive(false);
        Time.timeScale = 1.0f;
        solButton.SetActive(true);
        sagbutton.SetActive(true);
        ziplaButton.SetActive(true);

    }
    public void dilYuz()
    {
        GameObject top = GameObject.Find("top");
        top.GetComponent<SpriteRenderer>().sprite = dil;
        nextPanel.SetActive(false);
        Time.timeScale = 1.0f;
        solButton.SetActive(true);
        sagbutton.SetActive(true);
        ziplaButton.SetActive(true);
        dükkan.SetActive(true);

    }
    public void basla()
    {
        Time.timeScale = 1.0f;
        nextPanel.SetActive(false);
       
    }
    public void baslax()
    {
        Time.timeScale = 0.0f;
        baslaPanelx.SetActive(true);

    }
    public void baslaxkapat()
    {
        Time.timeScale = 1.0f;
        baslaPanelx.SetActive(false);

    }
    //<>
    public void nextReklam()
    {
        if (Advertisement.IsReady("video"))
        {
            Advertisement.Show("video");
        }
    }
    public void reklamizle()
    {
        if (Advertisement.IsReady("rewardedVideo"))
        {
            Advertisement.Show("rewardedVideo");
            para = para + 5400;
            money.text = "GOLD : " + para.ToString();
        }
        else
        {
            Debug.Log("para yüklenmedi!");
        }
        
    }
    public void baslaReklam()
    {
        if (Advertisement.IsReady("rewardedVideo"))
        {
            Advertisement.Show("rewardedVideo");
            kPara = kPara + 2000;
            kalanPara.text = "Remaining Money: " + kPara.ToString() + "TL";
        }

    }
    public void jump()
    {
        if(kPara >= 2000)
        {
            kPara = kPara - 2000;
            kalanPara.text="Remaining Money: " + kPara.ToString()+ "TL";
            ziplamaHizi = ziplamaHizi + 25000;
            Destroy(jumpp);
        }
    }
    public void speed()
    {
        if (kPara >= 3400)
        {
            kPara = kPara - 3400;
            saghiz = saghiz + 1500;
            solhiz = solhiz + 1500;
            kalanPara.text = "Remaining Money: " + kPara.ToString() + "TL";
            Destroy(speeed);
        }
    }
    public void time()
    {
        if (kPara >= 2400)
        {
            kPara = kPara - 2400;
            kalanPara.text = "Remaining Money: " + kPara.ToString() + "TL";
            saniye = saniye + 30;
            zaman.text = "Time: " + saniye.ToString("f");
            Destroy(ttime);
        }
    }
    public void timeIki()
    {
        if (kPara >= 2400)
        {
            para = para - 2400;
            money.text = "Gold : " + para.ToString();
           // süreBaslaa = süreBaslaa - 30;
           // sürezamaen.text = "Time: " + süreBaslaa.ToString("f");
           // Destroy(timeA);
        }
    }
    public void IkinciLevelLoad()
    {
        SceneManager.LoadScene("2");
        int sonrakiLevel = int.Parse(Application.loadedLevelName) + 1;
        PlayerPrefs.SetInt(sonrakiLevel.ToString(), 1);
    }
    public void levelIkiYenidenIki()
    {
        SceneManager.LoadScene("2");
    }
    public void levelIkiYenidenUc()
    {
        SceneManager.LoadScene("3");
    }
    public void levelIkiYenidenDort()
    {
        SceneManager.LoadScene("4");
    }
    public void levelIkiYenidenBes()
    {
        SceneManager.LoadScene("5");
    }
    public void levelIkiYenidenAlti()
    {
        SceneManager.LoadScene("6");
    }
    public void levelIkiYenidenYedi()
    {
        SceneManager.LoadScene("7");
    }
    public void levelIkiYenidenSekiz()
    {
        SceneManager.LoadScene("8");
    }
    public void levelIkiYenidenOn()
    {
        SceneManager.LoadScene("10");
    }
    public void levelIkiYenidenOnBir()
    {
        SceneManager.LoadScene("11");
    }
    public void levelIkiYenidenOnIki()
    {
        SceneManager.LoadScene("12");
    }
    public void levelIkiYenidenOnUc()
    {
        SceneManager.LoadScene("13");
    }
    public void levelIkiYenidenOnDort()
    {
        SceneManager.LoadScene("14");
    }
    public void levelIkiYenidenOnBes()
    {
        SceneManager.LoadScene("15");
    }
    public void levelIkiYenidenOnAlti()
    {
        SceneManager.LoadScene("16");
    }
    public void levelIkiYenidenOnYedi()
    {
        SceneManager.LoadScene("17");
    }
    public void cikiss()
    {
        Application.Quit();
    }
    public void menuLevell()
    {
        SceneManager.LoadScene("levelMenu");
        
    }
    public void levelUceGecis()
    {
        SceneManager.LoadScene("3");
        int sonrakiLevel = int.Parse(Application.loadedLevelName) + 1;
        PlayerPrefs.SetInt(sonrakiLevel.ToString(), 1);
    }
    public void levelDorteGecis()
    {
        SceneManager.LoadScene("4");
        int sonrakiLevel = int.Parse(Application.loadedLevelName) + 1;
        PlayerPrefs.SetInt(sonrakiLevel.ToString(), 1);
    }
    public void levelBeseGecis()
    {
        SceneManager.LoadScene("5");
        int sonrakiLevel = int.Parse(Application.loadedLevelName) + 1;
        PlayerPrefs.SetInt(sonrakiLevel.ToString(), 1);
    }
    public void levelAltiGecis()
    {
        SceneManager.LoadScene("6");
        int sonrakiLevel = int.Parse(Application.loadedLevelName) + 1;
        PlayerPrefs.SetInt(sonrakiLevel.ToString(), 1);
    }
    public void levelYediGecis()
    {
        SceneManager.LoadScene("7");
        int sonrakiLevel = int.Parse(Application.loadedLevelName) + 1;
        PlayerPrefs.SetInt(sonrakiLevel.ToString(), 1);
    }
    public void levelSekizGecis()
    {
        SceneManager.LoadScene("8");
        int sonrakiLevel = int.Parse(Application.loadedLevelName) + 1;
        PlayerPrefs.SetInt(sonrakiLevel.ToString(), 1);
    }
    public void digerLevelGecis()
    {
        SceneManager.LoadScene("levelIki");
        int sonrakiLevel = int.Parse(Application.loadedLevelName) + 1;
        PlayerPrefs.SetInt(sonrakiLevel.ToString(), 1);
        int sonrakiLevelIki = int.Parse(Application.loadedLevelName) + 2;
        PlayerPrefs.SetInt(sonrakiLevelIki.ToString(), 2);
    }
    public void levelOnBirGecis()
    {
        SceneManager.LoadScene("11");
        int sonrakiLevel = int.Parse(Application.loadedLevelName) + 1;
        PlayerPrefs.SetInt(sonrakiLevel.ToString(), 1);
    }
    public void levelOnIkiGecis()
    {
        SceneManager.LoadScene("12");
        int sonrakiLevel = int.Parse(Application.loadedLevelName) + 1;
        PlayerPrefs.SetInt(sonrakiLevel.ToString(), 1);
    }
    public void levelOnUceGecis()
    {
        SceneManager.LoadScene("13");
        int sonrakiLevel = int.Parse(Application.loadedLevelName) + 1;
        PlayerPrefs.SetInt(sonrakiLevel.ToString(), 1);
    }
    public void levelOnDordeGecis()
    {
        SceneManager.LoadScene("14");
        int sonrakiLevel = int.Parse(Application.loadedLevelName) + 1;
        PlayerPrefs.SetInt(sonrakiLevel.ToString(), 1);
    }
    public void levelOnBesGecis()
    {
        SceneManager.LoadScene("15");
        int sonrakiLevel = int.Parse(Application.loadedLevelName) + 1;
        PlayerPrefs.SetInt(sonrakiLevel.ToString(), 1);
    }
    public void levelOnAltiyaGecis()
    {
        SceneManager.LoadScene("16");
        int sonrakiLevel = int.Parse(Application.loadedLevelName) + 1;
        PlayerPrefs.SetInt(sonrakiLevel.ToString(), 1);
    }
    public void levelOnYediyeGecis()
    {
        SceneManager.LoadScene("17");
        int sonrakiLevel = int.Parse(Application.loadedLevelName) + 1;
        PlayerPrefs.SetInt(sonrakiLevel.ToString(), 1);
    }
    public void bittiFinish()
    {
        SceneManager.LoadScene("bittii");
        
    }
}

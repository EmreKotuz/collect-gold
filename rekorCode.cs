using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class rekorCode : MonoBehaviour
{
    public float süreBasla = 0f;
    public TextMeshProUGUI süree;
    public int randomm;
    public GameObject nesneBitis;
    public TextMeshProUGUI skor;
    // Start is called before the first frame update
    void Start()
    {
        randomm = Random.Range(1, 5);

        if (randomm == 1)
        {
            nesneBitis.transform.Translate(-217f, -469f, 0);
        }
        else if (randomm == 2)
        {
            nesneBitis.transform.Translate(-103f, 631f, 0);

        }
        else if (randomm == 3)
        {
            nesneBitis.transform.Translate(-759f, 806f, 0);

        }
        else
        {
            nesneBitis.transform.Translate(0, 0, 0);

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1.0f)
        {
            süreBasla += Time.deltaTime;
            süree.text = "Time : " + süreBasla.ToString("f");
            skor.text = "GREAT! " + süreBasla.ToString("f");

        }
    }
    public void yeniden()
    {
        SceneManager.LoadScene("rekor");
    }
 
}

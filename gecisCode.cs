using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gecisCode : MonoBehaviour
{
    public float geriSayim = 3;
    // Update is called once per frame
    void Update()
    {//><
        geriSayim -= Time.deltaTime;
        if(geriSayim < 0)
        {
            SceneManager.LoadScene("anaMenu");
        }
    }
}

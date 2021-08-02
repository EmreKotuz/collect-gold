using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class anaCode : MonoBehaviour
{
    public void rekoraGecis()
    {
        SceneManager.LoadScene("rekor");
    }
    public void leveleGeciss()
    {
        SceneManager.LoadScene("levelMenu");
    }
}

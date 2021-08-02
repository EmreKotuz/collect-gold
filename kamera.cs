using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour
{
    public GameObject top;
    Vector3 mesafe;

    // Start is called before the first frame update
    void Start()
    {
        

        mesafe =  transform.position - top.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = top.transform.position + mesafe;

    }
}

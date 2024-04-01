using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // ¹è¿­
    List<string> list = new List<string>();
    ArrayList arrayList = new ArrayList();

    // ÀÚ·á±¸Á¶
    public List<GameObject> gList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        //list.Add("³çÇÏ¼¼¿ä¾È");
        //list.Add("³çÈ÷°¡¼¼¿ä");

        //print(list[0]);
        //print(list[1]);

        for (int i = 0; i < gList.Count; i++)
        {
            Debug.Log(gList[i]);
        }
        /*arrayList.Add(0);
        arrayList.Add(1);
        arrayList.Add(2);
        arrayList.Add("¿¤·¼·¼·¹");
        arrayList.Add(4.5f);

        arrayList[2] = 3;

        for (int i = 0; i < arrayList.Count; i++)
        {
            Debug.Log(arrayList[i]);
        }*/
    }

    // Update is called once per frame
    void Update()
    {

    }
}

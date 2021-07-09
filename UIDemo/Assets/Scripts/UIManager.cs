using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject light1;
    public GameObject light2;

    public void Light()
    {
        //현재 게임오브젝트가 켜져있는지 체크
        if(light1.activeSelf == true ) //켜져있으면
        {
            light1.SetActive(false);
        }
        else
        {
            light1.SetActive(true);
        }
        light2.SetActive(!light2.activeSelf);
    }
}

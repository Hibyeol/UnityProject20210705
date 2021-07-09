using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class IntroManager : MonoBehaviour
{
    public void LoadGamePlay()
    {
        print("게임을 로드합니다");
        SceneManager.LoadScene("SampleScene");


    }
}

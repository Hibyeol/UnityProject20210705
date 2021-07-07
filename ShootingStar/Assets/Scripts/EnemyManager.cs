using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject enemyprefab;
    public float creatTime = 2.0f;
    void Start()
    {
        //1. enemy를 소품화 시킨다
        //2, 소품실 김군한테 부탁해서 복제품을 만든다
        //      instantiate
        //
    }
    float currentTime = 0.0f;
    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime > creatTime)
        {
            //2초가 지나면 들어온다
            GameObject enemy = Instantiate(enemyprefab);
            enemy.transform.position = transform.position;
            currentTime = 0.0f;
        }
    }

    void CreateEnemyKeyButtion()
    {
        if (Input.GetButtonDown("Jump") == true)
        {
            //transform.position = Vector3;
            GameObject enemy = Instantiate(enemyprefab);
            enemy.transform.position = transform.position;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject explosionprefab;
    GameObject target;
    public float speed = 5.0f;
    public int probability = 50;
    Vector3 dir;
    void Start()
    {
        target = GameObject.Find("Player");
        if(target ==null)
        {
            print("GameOver");
            dir = Vector3.down;
            return;
        }
        int rand = Random.Range(0, 100);
        if (rand < probability)
        {
            dir = target.transform.position - transform.position;
        }
        else
        {
            dir = Vector3.down;
        }
        dir.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * dir * Time.deltaTime;
    }

    //충돌이벤트 함수 //충돌조건이 만족 할 경우 
    private void OnCollisionEnter(Collision collision)
    {
        //print("충돌됐습니다");
        //총알과 자기자신을 파괴하자

        GameObject boom = Instantiate(explosionprefab);
        boom.transform.position = transform.position;

        if (collision.gameObject.name.Contains("Player") == true)//player를 포함하고 있으면
        {
            Player p = collision.gameObject.GetComponent<Player>();
            p.hp--;
            p.CalcPlayerHp();
            if (p.hp<0)
            {
                Destroy(collision.gameObject);
            }
        }
        else
        {
            Destroy(collision.gameObject); //총알과 플레이어제거
        }
        Destroy(gameObject);//자기자신의 오브젝트 제거
        GameObject sm = GameObject.Find("ScoreManager");
        ScoreManager s = sm.GetComponent<ScoreManager>();
        s.CalcScore(10);
    }
}

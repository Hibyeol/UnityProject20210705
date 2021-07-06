using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject target;
    public float speed = 5.0f;
    public int probability = 50;
    Vector3 dir;
    void Start()
    {
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
}

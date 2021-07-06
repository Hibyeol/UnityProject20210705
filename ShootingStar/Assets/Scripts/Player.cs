using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 0.02f;
    Transform tr;
    // Start is called before the first frame update

    void Start()
    {
        tr = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        print(h);


        Vector3 dir = (Vector3.right*h + Vector3.up*v);
        dir.Normalize();
        transform.position += speed * dir * Time.deltaTime;
    }
}

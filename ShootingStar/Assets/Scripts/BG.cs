using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG : MonoBehaviour
{
    public float speed = 20.0f;
    MeshRenderer mr;
    // Start is called before the first frame update
    void Start()
    {
       mr = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //mr.material.mainTextureOffset += Vector2.up * speed * Time.deltaTime;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed = 0.02f;
    Transform tr;
    // Start is called before the first frame update
    Joystick js; //조이스틱

    //플레이어의 체력
    [System.NonSerialized] // 인스펙터창(레고블럭)에 public이지만 노출을 하지 않겠다
    public int hp = 0;
    public int maxHP = 10;
    public Image hpBar;

    void Start()
    {
        hp = maxHP;
        tr = GetComponent<Transform>();
        js = FindObjectOfType<Joystick>();
    }

    // Update is called once per frame
    void Update()
    {
        //float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");
    


        float h = Input.GetAxis("Horizontal") + js.Horizontal;
        float v = Input.GetAxis("Vertical") + js.Vertical;
        Debug.Log(h);
        Debug.Log(v);

        Vector3 dir = (Vector3.right * h + Vector3.up * v);
        dir.Normalize();
        transform.position += speed * dir * Time.deltaTime;

        //클리핑
        //player x위치 : -9.0f ~ 8.5f 사이 y위치 -8.1f: ~ 18.7f

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -8.9f, 8.5f);
        pos.y = Mathf.Clamp(pos.y, -8.2f, 18.7f);
        
        // pos.x = Clamp(pos.x, -8.9f, 8.5f);
        //pos.y = Clamp(pos.y, -8.1f, 18.7f);
        /*
        

        if (transform.position.x > 18.7f)
        {
            pos.x = 18.7f;
        }
        if (transform.position.x < -8.1f)
        {
            pos.x = -8.1f;
        }
        transform.position = pos;*/
        transform.position = pos;
    }

    float Clamp(float value, float min, float max)
    {
        if (transform.position.x > max)
        {
            value = max;
        }
        else if (transform.position.x < min)
        {
            value = min;
        }
        if (transform.position.y > max)
        {
            value = max;
        }
        else if (transform.position.y < min)
        {
            value = min;
        }
        return value ;
    }

    public void CalcPlayerHp() {

        hpBar.fillAmount = (float)hp / (float)maxHP;
            
    }

}

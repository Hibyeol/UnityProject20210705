using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletPrefab;

  

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetButtonDown("Fire1") == true)
        {
            Shot4bullet();
        }
        if (Input.GetButtonDown("Fire2") == true)
        {
            CircleBullet();
        }
        if (Input.GetButtonDown("Jump") == true)
        {
            SpireBullet();
        }
    }

    public void Shot4bullet()
    {

        GameObject bullet = Instantiate(bulletPrefab);
        bullet.transform.position = transform.position + new Vector3(-0.3f, 0.0f, 0.0f);

        GameObject bullet2 = Instantiate(bulletPrefab);
        bullet2.transform.position = transform.position + new Vector3(0.3f, 0.0f, 0.0f);

        GameObject bullet3 = Instantiate(bulletPrefab);
        bullet3.transform.position = transform.position + new Vector3(-0.3f, 0.0f, 0.0f);
        bullet3.transform.eulerAngles = new Vector3(0.0f, 0.0f, 20.0f);

        GameObject bullet4 = Instantiate(bulletPrefab);
        bullet4.transform.position = transform.position + new Vector3(0.3f, 0.0f, 0.0f);
        bullet4.transform.eulerAngles = new Vector3(0.0f, 0.0f, -20.0f);

    }

    public void CircleBullet()
    {
        for (int i = 0; i < 36; i++)
        {
            GameObject bullet = Instantiate(bulletPrefab);
            bullet.transform.position = transform.position;
            bullet.transform.eulerAngles = new Vector3(0.0f, 0.0f, i * 10.0f);
        }

    }
    public int nAngle = 0;
    public void SpireBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab);
        bullet.transform.position = transform.position;
        bullet.transform.eulerAngles = new Vector3(0.0f, 0.0f, nAngle * 10.0f);
        nAngle++;
        if(nAngle>=36)
        {
            nAngle = 0;
        }
    }

}

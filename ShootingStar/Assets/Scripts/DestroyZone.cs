using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {//감지된 대상을 파괴하자
        Destroy(other.gameObject);
    }
}

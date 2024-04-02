using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject bullet; // 미사일 프리팹 가져올 변수

    // Start is called before the first frame update
    void Start()
    {
        // InvokeRepeating(함수 이름, 초기 지연 시간 ,지연할 시간);
        InvokeRepeating("Shoot", 0.5f, 0.01f);
    }

    void Shoot()
    {
        // 미사일 프리팹, 런쳐 포지션, 방향값 없음
        Instantiate(bullet, transform.position, Quaternion.identity);
        // 사운드 플레이
        SoundManager.instance.PlayerSound();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

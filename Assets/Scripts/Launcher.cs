using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject bullet; // �̻��� ������ ������ ����

    // Start is called before the first frame update
    void Start()
    {
        // InvokeRepeating(�Լ� �̸�, �ʱ� ���� �ð� ,������ �ð�);
        InvokeRepeating("Shoot", 0.5f, 0.01f);
    }

    void Shoot()
    {
        // �̻��� ������, ���� ������, ���Ⱚ ����
        Instantiate(bullet, transform.position, Quaternion.identity);
        // ���� �÷���
        SoundManager.instance.PlayerSound();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

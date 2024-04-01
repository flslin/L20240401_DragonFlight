using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 2f;

    void Start()
    {
        
    }

    void Update()
    {
        // y�� �̵�
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }

    // ȭ�� �ٲ��� ������ �Ⱥ��� ��� ȣ���� �Ǵ� �Լ�
    private void OnBecameInvisible()
    {
        // �̻��� �����
        Destroy(gameObject);
    }

    // Ʈ���� �浹
    // �ݸ��� �浹
    // enter ���� �� 1��
    // stay ��� �浹 ���� �ȿ�
    // exit �浹 ���� �� 1��
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // �̻��ϰ� ���� �浹
        //if(collision.gameObject.tag == "Enemy") // �� ���������� ���� �ڵ尡 �����ϴٰ� ��
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // �� �����
            Destroy(collision.gameObject);

            // �� �ڽ� ����� (�̻���)
            Destroy(gameObject);
        }
    }

}

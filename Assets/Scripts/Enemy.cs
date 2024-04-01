using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �������� ������ �����
        float distanceY = moveSpeed * Time.deltaTime;
        // �������� �ݿ�
        transform.Translate(0, -distanceY, 0);
    }

    // ȭ�鿡�� �����
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // ���ǵ�
    public float moveSpeed = 3;
    //private float xRange = 2.6f;

    void Start()
    {

    }

    void Update()
    {

        //if (transform.position.x > 2.6f)
        //{
        //    transform.position = new Vector3(2.6f, transform.position.y, transform.position.z);
        //}
        //else if (transform.position.x < -2.6f)
        //{
        //    transform.position = new Vector3(-2.6f, transform.position.y, transform.position.z);
        //}
        //else
        //{
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float distanceY = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        // x�� ���� vector ���� * �ð� * ���ǵ�
        // x �̵� ����
        transform.Translate(distanceX, distanceY, 0);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2.6f, 2.6f), Mathf.Clamp(transform.position.y, -5f, 4.5f), transform.position.z);
        //}
    }
}

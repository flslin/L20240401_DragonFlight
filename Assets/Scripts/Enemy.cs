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
        // 움직임을 변수로 만들기
        float distanceY = moveSpeed * Time.deltaTime;
        // 움직임을 반영
        transform.Translate(0, -distanceY, 0);
    }

    // 화면에서 벗어나면
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}

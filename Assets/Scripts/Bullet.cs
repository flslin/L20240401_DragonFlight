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
        // y축 이동
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }

    // 화면 바끙로 나가면 안보일 경우 호출이 되는 함수
    private void OnBecameInvisible()
    {
        // 미사일 지우기
        Destroy(gameObject);
    }

    // 트리거 충돌
    // 콜리전 충돌
    // enter 들어올 때 1번
    // stay 계속 충돌 범위 안에
    // exit 충돌 끝날 때 1번
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 미사일과 적이 충돌
        //if(collision.gameObject.tag == "Enemy") // 도 가능하지만 밑의 코드가 안전하다고 함
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // 적 지우기
            Destroy(collision.gameObject);

            // 나 자신 지우기 (미사일)
            Destroy(gameObject);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 2f;
    SpriteRenderer myMaterial;
    int collisionCount = 0;
    public GameObject myParticle;

    // Start is called before the first frame update
    void Start()
    {
        myMaterial = GetComponent<SpriteRenderer>();
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            if (collisionCount == 0)
            {
                StartCoroutine(ChangeColor());
                collisionCount++;
                Destroy(other.gameObject);
            }

            else if (collisionCount == 1)
            {
                //GameObject go = Instantiate(explosion, transform.position, Quaternion.identity);
                //Destroy(go, 1);

                // 적 지우기
                Destroy(other.gameObject);
                GameObject go = Instantiate(myParticle, transform.position, Quaternion.identity);
                Destroy(go, 0.5f);

                // 사운드
                SoundManager.instance.SoundDie();

                // 점수
                GameManager.instance.AddScore(100);

                // 나 자신 지우기 (미사일)
                Destroy(gameObject);
            }
        }
    }
    IEnumerator ChangeColor()
    {
        myMaterial.color = new Color(255 / 255f, 40 / 255f, 30 / 255f, 240 / 255f);
        Debug.Log("ChangeColor");
        yield return new WaitForSeconds(.3f);
        myMaterial.color = new Color(255, 255, 255, 255);
    }

}

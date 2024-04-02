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

                // �� �����
                Destroy(other.gameObject);
                GameObject go = Instantiate(myParticle, transform.position, Quaternion.identity);
                Destroy(go, 0.5f);

                // ����
                SoundManager.instance.SoundDie();

                // ����
                GameManager.instance.AddScore(100);

                // �� �ڽ� ����� (�̻���)
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

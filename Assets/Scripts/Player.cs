using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour, IDragHandler
{
    // 스피드
    public float moveSpeed = 3;
    //private float xRange = 2.6f;

    public GameObject player;
    public Vector3 mousePos;

    void Start()
    {

    }

    void Update()
    {
        Move();
        //player.transform.position = mousePos;
        //OnMouseDown();
    }

    void Move()
    {
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float distanceY = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        // x값 설정 vector 방향 * 시간 * 스피드
        // x 이동 설정
        transform.Translate(distanceX, distanceY, 0);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2.6f, 2.6f), Mathf.Clamp(transform.position.y, -5f, 4.5f), transform.position.z);
    }

    public void OnDrag(PointerEventData eventData)
    {
        //mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
    }

    private void OnMouseDrag()
    {
        mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        player.transform.position = Camera.main.ScreenToWorldPoint(mousePos);
        //player.transform.position = Camera.main.ScreenToWorldPoint(mousePos);
    }



    //private void OnMouseDown()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        if (player.gameObject.CompareTag("Player"))
    //        {
    //            player.gameObject.transform.position = transform.position;
    //        }
    //    }
    //}

}

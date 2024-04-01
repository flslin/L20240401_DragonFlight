using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    // 스크롤이 되는 백그라운드
    public float scrollSpeed = 1f;
    private Material myMaterial;

    void Start()
    {
        // Material 가지고오기
        myMaterial = GetComponent<Renderer>().material;
    }

    void Update()
    {
        // Offset Material에서 가져오기
        Vector2 newOffset = myMaterial.mainTextureOffset;

        // 새롭게 offset바꿔주기
        // y부분값을 속도에 프레임 보정해서 더해줌
        newOffset.Set(0, newOffset.y + (scrollSpeed * Time.deltaTime));
        // Material에 offset값을 넣어줌
        myMaterial.mainTextureOffset = newOffset;
    }
}

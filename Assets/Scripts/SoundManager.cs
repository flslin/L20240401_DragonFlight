using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // 싱글톤
    public static SoundManager instance; // 자기자신을 변수로 만들고 어디서든 가져다 사용 가능

    AudioSource m_Audio; // AudioSource 컴포넌트를 변수로 만듦

    public AudioClip soundExplosion;
    public AudioClip soundDie;

    private void Awake()
    {
        if (instance == null) // instance가 비어있는지 검사
        {
            instance = this; // 자기참조객체
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        m_Audio = GetComponent<AudioSource>();
    }

    public void PlayerSound()
    {
        m_Audio.PlayOneShot(soundExplosion);
    }
    
    public void SoundDie()
    {
        m_Audio.PlayOneShot(soundDie);
    }
}

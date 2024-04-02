using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // �̱���
    public static SoundManager instance; // �ڱ��ڽ��� ������ ����� ��𼭵� ������ ��� ����

    AudioSource m_Audio; // AudioSource ������Ʈ�� ������ ����

    public AudioClip soundExplosion;
    public AudioClip soundDie;

    private void Awake()
    {
        if (instance == null) // instance�� ����ִ��� �˻�
        {
            instance = this; // �ڱ�������ü
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

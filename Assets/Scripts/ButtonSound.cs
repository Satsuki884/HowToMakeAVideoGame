using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSound : MonoBehaviour
{
    protected AudioSource audioSource; // ������ �� AudioSource
    //public Button button; // ������ �� ������

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        // ��������� ��������� ������� ������� �� ������
        //button.onClick.AddListener(PlayButtonSound);
    }

    public void PlayButtonSound()
    {
        audioSource.Play();
    }
}

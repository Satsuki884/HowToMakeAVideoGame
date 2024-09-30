using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSound : MonoBehaviour
{
    protected AudioSource audioSource; // Ссылка на AudioSource
    //public Button button; // Ссылка на кнопку

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        // Добавляем слушатель события нажатия на кнопку
        //button.onClick.AddListener(PlayButtonSound);
    }

    public void PlayButtonSound()
    {
        audioSource.Play();
    }
}

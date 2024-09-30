
using UnityEngine;

public class ENDTrigger : MonoBehaviour
{
    public GameManager gameManager;

    public AudioClip soundClip; // Аудиоклип, который нужно воспроизвести
    private AudioSource playerAudioSource;

    private void Start()
    {
        // Получаем компонент AudioSource от игрока
        GameObject player = GameObject.FindWithTag("Player"); // Предполагается, что у игрока есть тег "Player"
        if (player != null)
        {
            playerAudioSource = player.GetComponent<AudioSource>();
        }
        else
        {
            Debug.LogError("Player object not found. Please ensure it has the 'Player' tag.");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Вызываем метод завершения уровня
            gameManager.CompleteLevel();

            // Воспроизводим звук, если AudioSource найден
            if (playerAudioSource != null && soundClip != null)
            {
                playerAudioSource.PlayOneShot(soundClip);
            }
            else
            {
                Debug.LogError("AudioSource or AudioClip is missing.");
            }
        }
    }

}

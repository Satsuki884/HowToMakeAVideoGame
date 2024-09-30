
using UnityEngine;

public class ENDTrigger : MonoBehaviour
{
    public GameManager gameManager;

    public AudioClip soundClip; // ���������, ������� ����� �������������
    private AudioSource playerAudioSource;

    private void Start()
    {
        // �������� ��������� AudioSource �� ������
        GameObject player = GameObject.FindWithTag("Player"); // ��������������, ��� � ������ ���� ��� "Player"
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
            // �������� ����� ���������� ������
            gameManager.CompleteLevel();

            // ������������� ����, ���� AudioSource ������
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

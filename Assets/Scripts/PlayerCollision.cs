using Unity.VisualScripting;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    //public PlayerController controller;

    public AudioClip collisionSound;

    private AudioSource audioSource;

   // [SerializeField] private CharacterController _characterController;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            //_characterController.Move(Vector3.zero);
            //controller.enabled = false;
            PlaySound(collisionSound);
            FindObjectOfType<GameManager>().EndGame();
        } 
    }

    

    void PlaySound(AudioClip clip)
    {
        // Убедимся, что звук назначен
        if (clip != null)
        {
            audioSource.clip = clip;
            audioSource.Play();
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed = 5;
    [SerializeField] private float _speedRun = 5;
    [SerializeField] private CharacterController _characterController;

    private Animator _animator;
    private bool _isAlive = true;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    public void Die()
    {
        if (_isAlive)
        {
            return;
        }
        Debug.Log("игрок погиб");
        _animator.SetTrigger("Die");
        _isAlive = false;
    }

    public float jumpHeight = 2f;
    public float gravity = -9.81f;

    private Vector3 _velocity;
    private bool isGrounded;

    void Update()
    {


        _characterController.Move(Vector3.forward * _speedRun * Time.deltaTime);
        _characterController.Move(Vector3.right * _speed * Input.GetAxis("Horizontal") * Time.deltaTime);

        isGrounded = _characterController.isGrounded;

        // Если на земле, обнуляем вертикальную скорость
        if (isGrounded && _velocity.y < 0)
        {
            _velocity.y = -2f;
        }


        // Прыжок
        if (isGrounded && Input.GetButtonDown("ц"))
        {
            _velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);  // Рассчитываем необходимую вертикальную скорость для прыжка
        }

        // Применение гравитации
        _velocity.y += gravity * Time.deltaTime;

        // Применение движения по вертикали
        _characterController.Move(_velocity * Time.deltaTime);
    }

}

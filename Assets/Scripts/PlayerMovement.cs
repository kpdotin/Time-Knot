using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float _moveSpeed = 0.05f;
    private PlayerControls _controls;
    public Animator _animator;
    private void Awake()
    {
        _controls = new PlayerControls();
        _animator = GetComponent<Animator>();
    }

    //private void Start()
    //{
    //    _controls.Player.Movement.performed += ctx => PlayerMoving(ctx);
    //    _controls.Player.Movement.canceled += ctx => PlayerNotMoving(ctx);
    //}

    //void PlayerMoving(InputAction.CallbackContext ctx)
    //{
    //    _animator.Play("Move");
    //}

    //void PlayerNotMoving(InputAction.CallbackContext ctx)
    //{
    //    _animator.Play("Idle");

    //}
    private void OnEnable()
    {
        _controls.Enable();
    }

    private void OnDisable()
    {
        _controls.Disable();
    }

    // Update is called once per frame
    public void HandleUpdate()
    {

        if (_controls.Player.Movement.ReadValue<Vector2>().x != 0)
        {
            float movement = _controls.Player.Movement.ReadValue<Vector2>().x * _moveSpeed;
            transform.position += new Vector3(movement, 0, 0);
        }
        else
        {
            float movement = _controls.Player.Movement.ReadValue<Vector2>().y * _moveSpeed;
            transform.position += new Vector3(0, movement, 0);
        }

        _animator.SetFloat("moveX", _controls.Player.Movement.ReadValue<Vector2>().x);
        _animator.SetFloat("moveY", _controls.Player.Movement.ReadValue<Vector2>().y);

    }
}

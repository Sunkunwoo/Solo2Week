using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : MoveController
{
    public Transform player;
    public Vector3 offset = new Vector3(0f, 0f, -10f);
    private Camera _camera;
    private Animator _animator;
    private bool isAnimationOn = false;
    private SpriteRenderer characterRenderer;
    public SpriteRenderer KnightSprite;
    public SpriteRenderer ElfSprite;

    private void Start()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        CrChange();
        Transform characterSprite = transform.Find(Gamemanager.I.selectCr);
        characterRenderer = characterSprite.GetComponent<SpriteRenderer>();
        _animator = characterSprite.GetComponent<Animator>();
        _camera.transform.position = Vector3.Lerp(_camera.transform.position, player.position + offset, Time.deltaTime * 5f);
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        ToggleAnimationState(moveInput);
        OnTurn(moveInput);
        CallMoveEvent(moveInput);
    }

    public void OnTurn(Vector2 moveInput)
    {
        if (moveInput.x < 0)
        {
            characterRenderer.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            characterRenderer.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    private void ToggleAnimationState(Vector2 input)
    {
        if (input.x != 0 || input.y != 0)
        {
            _animator.SetBool("Move", true);
        }
        else
        {
            _animator.SetBool("Move", false);
        }
    }

    void CrChange()
    {
        if(Gamemanager.I.selectCr == "Knight")
        {
            KnightSprite.gameObject.SetActive(true);
            ElfSprite.gameObject.SetActive(false);
        }
        else
        {
            KnightSprite.gameObject.SetActive(false);
            ElfSprite.gameObject.SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] Animator _animator;

    public void MoveUp()
    {
        _animator.SetBool("Up", true);
    }

    public void MoveDown()
    {
        _animator.SetBool("Down", true);
    }

    public void MoveLeft()
    {
        _animator.SetBool("Left", true);
    }

    public void MoveRight()
    {
        _animator.SetBool("Right", true);
    }

    public void StopAnim()
    {
        _animator.SetBool("Up", false);
        _animator.SetBool("Down", false);
        _animator.SetBool("Left", false);
        _animator.SetBool("Right", false);
    }
}

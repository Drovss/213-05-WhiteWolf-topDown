using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _player;
    [SerializeField] private Vector2 _direction;
   
    private bool _isMove = false;

    public UnityEvent MoveEvent;
    public UnityEvent StopEvent;

    private void Update()
    {
        if (_isMove)
        {
            Move();
        }
    }

    public void Move()
    {
        _player.Translate(_direction * _speed * Time.deltaTime);
    }    

    public void OnPointerDown(PointerEventData eventData)
    {

        MoveEvent.Invoke();
        _isMove = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        StopEvent.Invoke();
        _isMove = false;
    }
}

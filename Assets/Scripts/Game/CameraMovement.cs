using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform _player;

    [SerializeField] private float _maxPosUp;
    [SerializeField] private float _maxPosDown;
    [SerializeField] private float _maxPosLeft;
    [SerializeField] private float _maxPosRight;

    private Transform _tr;

    private Vector3 _pos = new Vector3();

    private void Start()
    {
        _tr = GetComponent<Transform>();

        _pos = _tr.position;
    }

    private void Update()
    {
        _pos.x = _player.position.x;
        _pos.y = _player.position.y;
    }

    private void LateUpdate()
    {
        if (_pos.y > _maxPosUp)
        {
            _pos.y = _maxPosUp;

        }

        if (_pos.y < _maxPosDown)
        {
            _pos.y = _maxPosDown;

        }

        if (_pos.x < _maxPosLeft)
        {
            _pos.x = _maxPosLeft;

        }

        if (_pos.x > _maxPosRight)
        {
            _pos.x = _maxPosRight;

        }

        _tr.position = _pos;
    }
}

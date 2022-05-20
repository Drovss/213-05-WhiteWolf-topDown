using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textTimer;
    [SerializeField] private float _timeTimer;

    private float _timeActivation;
    private float _time;

    private bool _isEndTimer;

    public UnityEvent EndTimerEvent;

    private void Start()
    {
        Restart();
        _isEndTimer = false;
    }

    private void Update()
    {
        SetTimer();

        if (!_isEndTimer && Time.time > _timeActivation)
        {
            EndTimerEvent.Invoke();
            _isEndTimer = true;
        }
    }

    private void SetTimer()
    {
        if (_time > 0)
        {
            _time -= Time.deltaTime;

            TimeSpan timeSpan = TimeSpan.FromSeconds(_time);
            string timeString = timeSpan.ToString("mm':'ss");

            _textTimer.SetText(timeString);
        }
    }

    public void Restart()
    {
        _timeActivation = Time.time + _timeTimer;
        _time = _timeTimer;
    }
}

using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    [Space]
    [SerializeField] private int _minCountFood = 10;
    [SerializeField] private int _maxCountFood = 20;

    private int _countFood;
    private int _score;

    public UnityEvent WinEvent;

    private void Start()
    {
        _countFood = Random.Range(_minCountFood, _maxCountFood);
        _score = 0;
        _scoreText.SetText(_score.ToString() + "/" + _countFood.ToString());
    }    

    public void UpScore()
    {
        _score++;
        _scoreText.SetText(_score.ToString() + "/" + _countFood.ToString());

        CheckScore();
    }    

    private void CheckScore()
    {
        if (_score >= _countFood)
        {
            WinEvent.Invoke();
        }
    }
}

using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private List<Vector2> _positionSpawn;

    [SerializeField] private int _countStartSpawn = 10;

    private Transform _tr;

    private void OnEnable()
    {
        Meat.FindFoodEvent += Spawn;
    }

    private void OnDisable()
    {
        Meat.FindFoodEvent -= Spawn;
    }

    private void Start()
    {
        _tr = GetComponent<Transform>();

        for (int i = 0; i < _countStartSpawn; i++)
        {
            Spawn();
        }
        
    }

    public void Spawn()
    {
        Instantiate(_prefab, _positionSpawn[Random.Range(0, _positionSpawn.Count)], Quaternion.identity, _tr);
    }
}

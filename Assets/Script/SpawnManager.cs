using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

    public GameControl GameControl;
    
    [SerializeField] private GameObject[] vehiclePrefab;
    private GameObject _vehicle;
    public Vector2[] spawnPos = new Vector2[]{
        new Vector2(-10.8f, -0.5f),
        new Vector2(-11.0f, 1.2f)
    };
    
    void Start() {
        int index = Random.Range(0, vehiclePrefab.Length);
        int posChoice = Random.Range(0, spawnPos.Length);
        _vehicle = Instantiate(vehiclePrefab[index], transform);
        _vehicle.transform.position = (spawnPos[posChoice]);
    }

    void Update() {
        int index = Random.Range(0, vehiclePrefab.Length);
        int posChoice = Random.Range(0, spawnPos.Length);
        if (!GameControl.IsGameOver() && _vehicle.IsDestroyed()) {
            GameControl.AddCount(1);
            _vehicle = Instantiate(vehiclePrefab[index], transform);
            _vehicle.transform.position = (spawnPos[posChoice]);
        }
    }
}

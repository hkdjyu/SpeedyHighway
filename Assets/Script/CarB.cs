using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarB : MonoBehaviour {

    public float speed = 2.0f;
    public Transform _pos;
    void Start() {
        _pos = GetComponent<Transform>();
    }

    void Update() {
        Vector2 deltaPos = new Vector2(speed * Time.deltaTime, 0);
        _pos.Translate(deltaPos);
        
        if (_pos.position.x > 11) {
            Destroy(this.gameObject);
        }
    }
}

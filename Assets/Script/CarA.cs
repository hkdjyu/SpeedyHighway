using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CarA : MonoBehaviour {

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
